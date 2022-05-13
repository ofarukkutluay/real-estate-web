namespace real_estate_web.Models.Database
{
    public class Blog : BaseEntity
    {
        public string BasePhotoPath { get; set; } = "/img/post-single-1.jpg";
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public DateOnly Date { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }


    }
}
