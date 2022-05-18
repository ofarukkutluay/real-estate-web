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
        private readonly IPropertyRepository _propertyRepository;
        private readonly IMapper _mapper;

        public AgentController(IAgentRepository agentRepository, IPropertyRepository propertyRepository,IMapper mapper)
        {
            _agentRepository = agentRepository;
            _propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        [HttpGet("agent/{id}")]
        public IActionResult Index(int id)
        {
            AgentDto agent = _agentRepository.GetAgentDto(id);
            AgentVM vm = _mapper.Map<AgentVM>(agent);
            IEnumerable<PropertyDto> agentProperties = _propertyRepository.GetListAgentIdPropertyDto(id);
            IEnumerable<PropertyVM> agentPropertyVm = _mapper.Map<IEnumerable<PropertyVM>>(agentProperties);
            return View(Tuple.Create<AgentVM,IEnumerable<PropertyVM>>(vm,agentPropertyVm));
        }

        [HttpGet("/agents")]
        public IActionResult All(int page=0)
        {
            int pageSize = 9;
            IEnumerable<AgentDto> agents = _agentRepository.GetListAgentDto();
            int sumPage = agents.Count() / pageSize;
            ViewBag.SumPage = sumPage == 0 ? 1 : sumPage;
            IEnumerable<AgentDto> sizedAgentDtos = agents.Skip(page*pageSize).Take(pageSize);
            IEnumerable<AgentVM> vm = _mapper.Map<IEnumerable<AgentVM> >(sizedAgentDtos);
            return View(vm);
        }


    }
}