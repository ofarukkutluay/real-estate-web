using System.ComponentModel.DataAnnotations;

namespace real_estate_web.Models.Database
{
    public class Contact : BaseEntity
    {
        [Required(ErrorMessage ="İçerik Başlık Açıklaması boş bırakılamaz!")]
        public string HeaderDescription { get; set; } 
        [Required]
        public string GoogleIFrameUrl { get; set; }
        [Required]
        public string Email { get; set; } 
        
        [Required]
        public string PhoneNumber { get; set; } 
        
        [Required]
        public string Address { get; set; }
        public string? FacebookUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? LinkedInUrl { get; set; }
        
    
    }
    
}