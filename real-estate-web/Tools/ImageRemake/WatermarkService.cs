

using System;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace real_estate_web.Tools.ImageRemake
{
    public class WatermarkService
    {
        public byte[] ApplyWatermark(ReadOnlySpan<byte> imageByte)
        {
            //using var imageStream = imageFile.OpenReadStream();
            using var image = Image.Load(imageByte);
            using var watermarkStream = File.OpenRead("wwwroot/img/watermark.png"); // Watermark resmini yükleyin
            using var watermark = Image.Load(watermarkStream);
 
            // Watermarkı boyutunu 207*170 olarak ayarla
            //watermark.Mutate(x => x.Resize(new ResizeOptions { Size = new Size(210, 210), Mode = ResizeMode.Max }));
            
            
            // Üstten bir kısımı kırpma
            var cropRectangle = new Rectangle(0, 20, image.Width, image.Height - 20); // İlk parametre soldan kırpmak için başlangıç konumu
            image.Mutate(x => x.Crop(cropRectangle));

            // Watermark resmini ana resmin üzerine ekleyin
            image.Mutate(x => x.DrawImage(watermark, new Point(10, image.Height - watermark.Height - 10), 1f)); // Konumu ve ölçeği ayarlayabilirsiniz


            // İsteğe bağlı olarak diğer işlemleri de uygulayabilirsiniz (boyutlandırma, döndürme, kırpma, vb.).
            // Örneğin, resmi 800x600 boyutuna boyutlandırmak için:
            //image.Mutate(x => x.Resize(new ResizeOptions { Size = new Size(800, 600), Mode = ResizeMode.Max }));

            // Watermark eklenmiş resmi kaydetme:
            //var outputPath = "wwwroot/images/watermarked/photo.jpg";
            //image.Save(outputPath);

            // İşlenmiş resmi bir MemoryStream içinde tutun
            using var outputStream = new MemoryStream();

            image.Save(outputStream, new JpegEncoder()); // İstediğiniz formata göre encoder'ı seçebilirsiniz

            //image.Dispose();
            //watermarkStream.Close();
            //watermarkStream.Dispose();
            //watermark.Dispose();
            
            // MemoryStream'i IFormFile'a dönüştürme
            //var outputFormFile = new FormFile(outputStream, 0, outputStream.Length, name, filename);
            //outputStream.Dispose();
            return outputStream.ToArray();

        }

    }

}