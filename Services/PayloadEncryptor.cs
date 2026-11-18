using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace SIHSALUS_DocumentGenerator.Services;

public sealed class PayloadEncryptor
{
    private const byte FormatVersion = 1;
    private const int KeySize = 32;
    private const int NonceSize = 12;
    private const int TagSize = 16;
    private const int HeaderSize = 1 + NonceSize + TagSize;
    private readonly byte[] _key = new byte[KeySize];

    public PayloadEncryptor(string encryptionKey)
    {
        if (!Convert.TryFromBase64String(encryptionKey, _key, out int bytesWritten) || bytesWritten != KeySize)
        {
            CryptographicOperations.ZeroMemory(_key);
            throw new InvalidOperationException("ENCRYPTION_KEY must contain 32 random bytes encoded as Base64.");
        }
    }

    public byte[] Encrypt(JsonElement payload)
    {
        byte[] plaintext = Encoding.UTF8.GetBytes(payload.GetRawText());
        try
        {
            // Envelope layout: version, nonce, authentication tag, ciphertext.
            byte[] envelope = new byte[HeaderSize + plaintext.Length];
            envelope[0] = FormatVersion;
            Span<byte> version = envelope.AsSpan(0, 1);
            Span<byte> nonce = envelope.AsSpan(1, NonceSize);
            Span<byte> tag = envelope.AsSpan(1 + NonceSize, TagSize);
            Span<byte> ciphertext = envelope.AsSpan(HeaderSize);

            RandomNumberGenerator.Fill(nonce);
            using var aes = new AesGcm(_key, TagSize);
            aes.Encrypt(nonce, plaintext, ciphertext, tag, version);
            return envelope;
        }
        finally
        {
            CryptographicOperations.ZeroMemory(plaintext);
        }
    }
}
