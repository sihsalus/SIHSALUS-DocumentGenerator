using ICSharpCode.SharpZipLib.Zip;

namespace SIHSALUS_DocumentGenerator.Utils;

public static class ZipHelper
{
    public static byte[] CreatePasswordProtectedEmptyZip(string password, string entryName = "empty.txt")
    {
        using MemoryStream memoryStream = new MemoryStream();
        using ZipOutputStream zipOutputStream = new ZipOutputStream(memoryStream);
        zipOutputStream.IsStreamOwner = false;
        zipOutputStream.Password = password;

        ZipEntry entry = new ZipEntry(entryName)
        {
            DateTime = DateTime.UtcNow,
            AESKeySize = 256,
            Size = 0
        };

        zipOutputStream.PutNextEntry(entry);
        zipOutputStream.CloseEntry();
        zipOutputStream.Finish();

        return memoryStream.ToArray();
    }
}
