using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database.Dtos;
using real_estate_web.Models.HelperEntities;
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

        [HttpGet("{title}-{id}")]
        public async Task<IActionResult> Index(int id)
        {
            PropertyDto Property = _propertyRepository.GetPropertyDto(id);
            if (Property is null)
            {
                return RedirectToAction("Index", "Home");
            }
            PropertyVM vm = _mapper.Map<PropertyVM>(Property);
            vm.PropertyPhotos = await _propertyPhotoRepository.GetListAsync(x => x.PropertyId == id);
            vm.AgentDto = _agentRepository.GetAgentDto(vm.AgentId);
            return View(vm);
        }

        [HttpGet("properties")]
        public IActionResult All(int page=0)
        {
            int pageSize = 12;
            IEnumerable<PropertyDto> properties = _propertyRepository.GetListPropertyDto().OrderBy(x=>x.Id);
            decimal sumPage = (decimal)properties.Count()/(decimal)pageSize;
            ViewBag.SumPage = Math.Ceiling(sumPage);
            IEnumerable<PropertyDto> sizedProperties = properties.Skip(page * pageSize).Take(pageSize);
            IEnumerable<PropertyVM> vm = _mapper.Map<IEnumerable<PropertyVM>>(sizedProperties);
            
            return View(vm);
        }


    }
}