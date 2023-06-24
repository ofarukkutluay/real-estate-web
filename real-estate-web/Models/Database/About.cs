namespace real_estate_web.Models.Database
{
    public class About : BaseEntity
    {
        public string Title { get; set; } 
        public string BodyTitle { get; set; } 
        public string BodyContentA { get; set; } 

        public string? BodyContentB { get; set; } 
    }
    
}