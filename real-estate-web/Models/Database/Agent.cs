namespace real_estate_web.Models.Database
{
    public class Agent : User
    {
        public string? PhoneNumber { get; set; }
        public string? Description { get; set; }
        public string? FacebookLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? LinkedinLink { get; set; }
        public string? InstagramLink { get; set; }
        public string? YoutubeLink { get; set; }
        public int? JobTitle { get; set; }
        public bool IsFavoritUser { get; set; } = false;
    }
}
