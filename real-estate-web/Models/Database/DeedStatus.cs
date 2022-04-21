using System.ComponentModel.DataAnnotations;

namespace real_estate_web.Models.Database
{
    public class DeedStatus  : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
