using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database.Dtos;
using real_estate_web.Models.ViewModel;

namespace real_estate_web.Controllers
{
    public class AgentController : BaseController
    {
        private readonly IAgentRepository _agentRepository;
        private readonly IMapper _mapper;

        public AgentController(IAgentRepository agentRepository,IMapper mapper)
        {
            _agentRepository = agentRepository;
            _mapper = mapper;
        }

        [HttpGet("agent/{id}")]
        public async Task<IActionResult> Index(int? id)
        {
            AgentDto agent = _agentRepository.GetAgentDto(id);
            AgentVM vm = _mapper.Map<AgentVM>(agent);
            return View(vm);
        }

        [HttpGet("/agents")]
        public async Task<IActionResult> All()
        {
            IEnumerable<AgentDto> agents = _agentRepository.GetListAgentDto();
            IEnumerable<AgentVM> vm = _mapper.Map<IEnumerable<AgentVM> >(agents);
            return View(vm);
        }


    }
}