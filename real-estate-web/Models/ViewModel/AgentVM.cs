namespace real_estate_web.Models.ViewModel
{
    public class AgentVM
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string Role { get; set; }
        public string? Description { get; set; }
        public string? FacebookLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? LinkedinLink { get; set; }
        public string? InstagramLink { get; set; }
        public string? YoutubeLink { get; set; }
        public int? JobTitleId { get; set; }
        public string? JobTitleName { get; set; }
        public int PropertyCount { get; set; }


        public IFormFile? ProfilePhoto { get; set; }
        public string ProfilePhotoPath { get; set; }
        public bool IsFavoritUser { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public string NewPassword { get; set; }
    }
}