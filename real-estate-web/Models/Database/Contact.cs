using System.ComponentModel.DataAnnotations;

namespace real_estate_web.Models.Database
{
    public class Contact : BaseEntity
    {
        [Required(ErrorMessage ="İçerik Başlık Açıklaması boş bırakılamaz!")]
        public string HeaderDescription { get; set; } = "Aut voluptas consequatur unde sed omnis ex placeat quis eos. Aut natus officia corrupti qui autem fugit consectetur quo. Et ipsum eveniet laboriosam voluptas beatae possimus qui ducimus. Et voluptatem deleniti. Voluptatum voluptatibus amet. Et esse sed omnis inventore hic culpa.";
        
        [Required]
        public string GoogleIFrameUrl { get; set; } ="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.665346984029!2d29.08746581564773!3d41.03257692587779!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cac8566285c3d7%3A0x60da11ebc95f76ce!2sTantavi%2C%20Estergon%20Cd.%20No%3A43%2C%2034764%20%C3%9Cmraniye%2F%C4%B0stanbul!5e0!3m2!1str!2str!4v1649872532554!5m2!1str!2str";
        
        [Required]
        public string Email { get; set; } = "contact@example.com";
        
        [Required]
        public string PhoneNumber { get; set; } = "+54 356 945234";
        
        [Required]
        public string Address { get; set; } = "Tantavi mahallesi Estergon Caddesi No: 43 Ümraniye/İstanbul";
        public string? FacebookUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? LinkedInUrl { get; set; }
        
    
    }
    
}