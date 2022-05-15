namespace real_estate_web.Models.Database
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public byte[] PassSalt { get; set; }
        public byte[] PassHash { get; set; } 
        public string ProfilePhotoPath { get; set; } = "/img/profile-img.jpg";
        public string Role { get; set; } = Roles.User;
        public string? RefreshToken { get; set; }
        public DateTime? RefresTokenExpireDate { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
