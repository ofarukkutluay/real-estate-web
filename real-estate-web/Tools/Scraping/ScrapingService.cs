using System.Text.Json;
using System.Text;
using real_estate_web.Tools.Helper;
using real_estate_web.Models.Database;
using ListingWebsiteScrapingLibrary;
using AutoMapper;

namespace real_estate_web.Tools.Scraping
{
    public class ScrapingService
    {
        private IMapper _mapper;
        public ScrapingService(IMapper mapper)
        {
            _mapper = mapper;
        }


        public async Task<Models.Database.PropertyListingDetail> GetSHListingDetail(string url, string document, string directoryPath)
        {
            ShScraping shScraping = new ShScraping();
            ListingWebsiteScrapingLibrary.PropertyListingDetail result = await shScraping.GetListingDetail(document);
            string datePath = Path.Combine(directoryPath, result.ListingDate?.ToString("dd-MM-yyyy"), result.Id.ToString());

            Models.Database.PropertyListingDetail listingDetail = _mapper.Map<Models.Database.PropertyListingDetail>(result);

            List<object> photoPaths = new List<object>();
           
            int thmbImgIndex = 0;
            foreach (var megaLink in result.PhotoLinks)
            {

                Uri uri = new Uri(megaLink);
                string fileNameAndExtension = uri.Segments.Last();

                string fullDirectory = Path.Combine("upload-images", datePath);
                string finalFileName = $"{thmbImgIndex}_{fileNameAndExtension}";

                if (FileHelper.HasFile(Path.Combine(Environment.CurrentDirectory, "wwwroot", fullDirectory, finalFileName)))
                {
                    photoPaths.Add(Path.Combine(fullDirectory, finalFileName));
                    listingDetail.PropertyPhotos.Add(new PropertyPhoto
                    {
                        Path = Path.Combine(fullDirectory, finalFileName),
                        SortIndex = thmbImgIndex,
                        PropertyListingDetailId = listingDetail.Id
                    });

                }
                else
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        var imageBytes = await httpClient.GetByteArrayAsync(uri);

                        using (Stream stream = new MemoryStream(imageBytes))
                        {
                            IFormFile formFile = new FormFile(stream, 0, imageBytes.Length, Path.GetFileNameWithoutExtension(fileNameAndExtension), finalFileName);

                            var fileResult = FileHelper.Add(formFile, datePath);
                            listingDetail.PropertyPhotos.Add(new PropertyPhoto
                            {
                                Path = fileResult,
                                SortIndex = thmbImgIndex,
                                PropertyListingDetailId = listingDetail.Id
                            });

                            photoPaths.Add(new { Path = fileResult, SortIndex = thmbImgIndex });
                        }

                    }
                }


                thmbImgIndex += 1;

            }

            listingDetail.PhotoLinks = JsonSerializer.Serialize(result.PhotoLinks);
            listingDetail.PhotoPaths = JsonSerializer.Serialize(photoPaths.ToArray());
            listingDetail.CreatedDate = DateTime.UtcNow;


            var options = new JsonSerializerOptions { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
            string jsonResult = JsonSerializer.Serialize(listingDetail, options);

            try
            {
                byte[] jsonByteArray = Encoding.UTF8.GetBytes(jsonResult);
                using (Stream stream1 = new MemoryStream(jsonByteArray))
                {
                    IFormFile formFile = new FormFile(stream1, 0, jsonByteArray.Length, "detail", "detail.json");
                    var fileResult = FileHelper.Add(formFile, datePath);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            return listingDetail;
        }
    }
}