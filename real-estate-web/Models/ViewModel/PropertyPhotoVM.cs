namespace real_estate_web.Models.ViewModel
{
    public class PropertyPhotoVM
    {
        public int PropertyId { get; set; }
        public bool BasePhoto { get; set; }
        public List<IFormFile> PropertyPhotos { get; set; }
    }
    
}