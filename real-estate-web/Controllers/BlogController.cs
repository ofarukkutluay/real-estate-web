using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;

namespace real_estate_web.Controllers
{
    public class BlogController : BaseController
    {

        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet("blog/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var blog = await _blogRepository.GetAsync(x=>x.Id==id);

            return View(blog);
        }

        [HttpGet("blogs")]
        public async Task<IActionResult> All()
        {
            var blogs = await _blogRepository.GetListAsync();

            return View(blogs);
        }

    }
}