using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database;

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
        public async Task<IActionResult> All(int page= 0)
        {
            int pageSize = 9;
            IEnumerable<Blog> blogs = await _blogRepository.GetListAsync();
            int sumPage = blogs.Count() / pageSize;
            ViewBag.SumPage = sumPage == 0 ? 1 : sumPage;
            IEnumerable<Blog> sizedBlogs = blogs.Skip(page*pageSize).Take(pageSize);

            return View(sizedBlogs);
        }

    }
}