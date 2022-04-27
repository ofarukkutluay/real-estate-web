using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using real_estate_web.Models.ViewModel;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database.Dtos;
using AutoMapper;

namespace real_estate_web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAgentRepository _agentRepository;
        private readonly IPropertyRepository _propertyRepository;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger,IAgentRepository agentRepository, IPropertyRepository propertyRepository,IMapper mapper)
        {
            _logger = logger;
            _agentRepository = agentRepository;
            _propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<AgentDto> allAgents = _agentRepository.GetListAgentDto().Where(x=>x.IsFavoritUser);
            IEnumerable<AgentVM> agentVMs = _mapper.Map<IEnumerable<AgentVM>>(allAgents);
           IEnumerable<PropertyDto> allPoperty = _propertyRepository.GetListPropertyDto();
            IEnumerable<PropertyVM> propertyVMs = _mapper.Map<IEnumerable<PropertyVM> >(allPoperty);
            return View(Tuple.Create<IEnumerable<AgentVM>,IEnumerable<PropertyVM>>(agentVMs,propertyVMs));
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