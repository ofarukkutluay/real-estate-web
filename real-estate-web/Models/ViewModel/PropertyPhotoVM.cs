using real_estate_web.Models.Database;

namespace real_estate_web.Models.ViewModel
{
    public class PropertyPhotoVM
    {
        public int PropertyId { get; set; }
        public List<IFormFile> FormFiles { get; set; }
        public List<PropertyPhoto> PropertyPhotos { get; set; }
    }
    
}