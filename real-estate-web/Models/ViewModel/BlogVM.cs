namespace real_estate_web.Models.ViewModel
{
    public class BlogVM
    {
        public int Id { get; set; }
        public string BasePhotoPath { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public IFormFile BasePhoto { get; set; }
    }
}
