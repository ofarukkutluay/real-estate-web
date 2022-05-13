using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database.Dtos;
using real_estate_web.Models.ViewModel;

namespace real_estate_web.Controllers
{
    public class PropertyController : BaseController
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IPropertyPhotoRepository _propertyPhotoRepository;
        private readonly IAgentRepository _agentRepository;
        private readonly IMapper _mapper;

        public PropertyController(IPropertyRepository propertyRepository, IPropertyPhotoRepository propertyPhotoRepository, IAgentRepository agentRepository,IMapper mapper)
        {
            _propertyRepository = propertyRepository;
            _propertyPhotoRepository = propertyPhotoRepository;
            _agentRepository = agentRepository;
            _mapper = mapper;
        }

        [HttpGet("property/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            PropertyDto Property = _propertyRepository.GetPropertyDto(id);
            PropertyVM vm = _mapper.Map<PropertyVM>(Property);
            var photos = await _propertyPhotoRepository.GetListAsync(x=>x.PropertyId == id);
            vm.PropertyPhotoPaths = photos.Select(x=>x.Path);
            vm.AgentDto = _agentRepository.GetAgentDto(vm.AgentId);
            return View(vm);
        }

        [HttpGet("properties")]
        public async Task<IActionResult> All()
        {
            IEnumerable<PropertyDto> Propertys = _propertyRepository.GetListPropertyDto();
            IEnumerable<PropertyVM> vm = _mapper.Map<IEnumerable<PropertyVM> >(Propertys);
            return View(vm);
        }


    }
}