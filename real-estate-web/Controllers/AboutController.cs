using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database;
using real_estate_web.Models.Database.Dtos;
using real_estate_web.Models.ViewModel;

namespace real_estate_web.Controllers
{
    public class AboutController : BaseController
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IAgentRepository _agentRepository;
        private readonly IMapper _mapper;
        public AboutController(IAboutRepository aboutRepository, IAgentRepository agentRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _agentRepository = agentRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutRepository.GetListAsync();
            var about = abouts.First();
            IEnumerable<AgentDto> agents = _agentRepository.GetListAgentDto();
            IEnumerable<AgentVM> agentVMs = _mapper.Map<IEnumerable<AgentVM>>(agents);
            
            return View(Tuple.Create<About,IEnumerable<AgentVM>>(about,agentVMs));
        }


    }
}