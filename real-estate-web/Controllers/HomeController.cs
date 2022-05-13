using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using real_estate_web.Models.ViewModel;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database.Dtos;
using AutoMapper;
using real_estate_web.Models.Database;

namespace real_estate_web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAgentRepository _agentRepository;
        private readonly IPropertyRepository _propertyRepository;
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IAgentRepository agentRepository, IPropertyRepository propertyRepository,IBlogRepository blogRepository, IMapper mapper)
        {
            _logger = logger;
            _agentRepository = agentRepository;
            _propertyRepository = propertyRepository;
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<AgentDto> allAgents = _agentRepository.GetListAgentDto().Where(x => x.IsFavoritUser);
            IEnumerable<AgentVM> agentVMs = _mapper.Map<IEnumerable<AgentVM>>(allAgents);
            IEnumerable<PropertyDto> allPoperty = _propertyRepository.GetListPropertyDto();
            IEnumerable<PropertyVM> propertyVMs = _mapper.Map<IEnumerable<PropertyVM>>(allPoperty);
            IEnumerable<Blog> blogs = await _blogRepository.GetListAsync();
            return View(Tuple.Create<IEnumerable<AgentVM>, IEnumerable<PropertyVM>, IEnumerable<Blog>>(agentVMs, propertyVMs,blogs));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}