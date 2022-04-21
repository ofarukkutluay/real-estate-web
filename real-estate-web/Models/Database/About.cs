namespace real_estate_web.Models.Database
{
    public class About : BaseEntity
    {
        public string Title { get; set; } = "Birlikte mutlu anılar biriktirebileceğiniz mülkler buluyoruz";
        public string BodyTitle { get; set; } = "Neden biz?";
        public string BodyContentA { get; set; } = @"Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.
         Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec,
          egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, 
          auctor sit amet aliquam vel, ullamcorper sit amet ligula.";

        public string? BodyContentB { get; set; } = @"Sed porttitor lectus nibh. Vivamus magna justo, lacinia eget consectetur sed, 
        convallis at tellus. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. 
        Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus.";
    }
    
}