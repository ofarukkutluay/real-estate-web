using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;

namespace real_estate_web.Controllers
{
    public class AboutController : BaseController
    {
        private readonly IAboutRepository _aboutRepository;
        public AboutController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutRepository.GetListAsync();
            var about = abouts.First();
            return View(about);
        }


    }
}