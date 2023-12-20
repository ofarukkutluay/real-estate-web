using System.IO;
using System.IO.Compression;
using Microsoft.AspNetCore.Hosting;

namespace real_estate_web.Tools.Services;

public class ZipService
{
    private readonly IWebHostEnvironment _hostingEnvironment;

    public ZipService(IWebHostEnvironment hostingEnvironment)
    {
        _hostingEnvironment = hostingEnvironment;
    }

    public byte[] ZipFiles(string folderPath)
    {
        var tempFolderPath = Path.Combine(_hostingEnvironment.ContentRootPath,"Temp", "TempZipFolder");

        // Klasörü temizle ve oluşturs
        if (Directory.Exists(tempFolderPath))
        {
            Directory.Delete(tempFolderPath, true);
        }
        Directory.CreateDirectory(tempFolderPath);

        // Belirtilen klasördeki dosyaları temp klasörüne kopyala
        var files = Directory.GetFiles(folderPath);
        foreach (var file in files)
        {
            var destPath = Path.Combine(tempFolderPath, Path.GetFileName(file));
            File.Copy(file, destPath);
        }

        // Zip dosyasını oluştur
        var zipFilePath = Path.Combine(_hostingEnvironment.ContentRootPath,"Temp", "TempZipFolder.zip");
        ZipFile.CreateFromDirectory(tempFolderPath, zipFilePath);

        // Zip dosyasını byte dizisine dönüştür
        byte[] zipBytes = File.ReadAllBytes(zipFilePath);

        // Temp klasörü ve zip dosyasını temizle
        Directory.Delete(tempFolderPath, true);
        File.Delete(zipFilePath);

        return zipBytes;
    }
}
