namespace real_estate_web.Models.ViewModel
{
    public class RegisterUserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public int? JobTitleId { get; set; }
        public string Role { get; set; }
    }
}
