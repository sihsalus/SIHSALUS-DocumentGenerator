namespace SIHSALUS_DocumentGenerator.Data;

public sealed class GeneratedFuaPayload
{
    public long Id { get; init; }
    public required byte[] EncryptedPayload { get; init; }
    public required DateTime GeneratedAtUtc { get; init; }
}
