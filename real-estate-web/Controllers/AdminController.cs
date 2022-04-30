using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Models.Database;
using real_estate_web.Data.Abstract;
using AutoMapper;
using real_estate_web.Models.ViewModel;
using real_estate_web.Models.Database.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using real_estate_web.Tools.Helper;

namespace real_estate_web.Controllers
{
    [Authorize(Roles = Role.AdminOrUser)]
    public class AdminController : BaseController
    {
        private readonly IJobTitleRepository _jobTitleRepository;
        private readonly IAboutRepository _aboutRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IAgentRepository _agentRepository;
        private readonly IDeedStatusRepository _deedStatusRepository;
        private readonly IHeatingTypeRepository _heatingTypeRepository;
        private readonly IInternetTypeRepository _internetTypeRepository;
        private readonly IPropertyTypeRepository _propertyTypeRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly IUsingStatusRepository _usingStatusRepository;
        private readonly IPropertyRepository _propertyRepository;
        private readonly IPropertyPhotoRepository _propertyPhotoRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IDistrictRepository _districtRepository;
        private readonly INeighborhoodRepository _neighborhoodRepository;
        private readonly IStreetRepository _streetRepository;
        private readonly IFrontRepository _frontRepository;
        private readonly IMapper _mapper;
        public AdminController(IJobTitleRepository jobTitleRepository, IAboutRepository aboutRepository,
                                    IContactRepository contactRepository, IAgentRepository agentRepository, IDeedStatusRepository deedStatusRepository,
                                    IHeatingTypeRepository heatingTypeRepository, IInternetTypeRepository internetTypeRepository, IPropertyTypeRepository propertyTypeRepository,
                                    IStatusRepository statusRepository, IUsingStatusRepository usingStatusRepository, IPropertyRepository propertyRepository,
                                    IPropertyPhotoRepository propertyPhotoRepository, ICityRepository cityRepository, IDistrictRepository districtRepository,
                                    INeighborhoodRepository neighborhoodRepository, IStreetRepository streetRepository, IFrontRepository frontRepository, IMapper mapper)
        {
            _jobTitleRepository = jobTitleRepository;
            _aboutRepository = aboutRepository;
            _contactRepository = contactRepository;
            _agentRepository = agentRepository;
            _deedStatusRepository = deedStatusRepository;
            _heatingTypeRepository = heatingTypeRepository;
            _internetTypeRepository = internetTypeRepository;
            _propertyTypeRepository = propertyTypeRepository;
            _statusRepository = statusRepository;
            _usingStatusRepository = usingStatusRepository;
            _propertyRepository = propertyRepository;
            _propertyPhotoRepository = propertyPhotoRepository;
            _cityRepository = cityRepository;
            _districtRepository = districtRepository;
            _neighborhoodRepository = neighborhoodRepository;
            _streetRepository = streetRepository;
            _frontRepository = frontRepository;
            _mapper = mapper;
        }


        //Admin welcome panel
        public IActionResult Index()
        {

            return View();
        }


        // JobTitle iş tanımı sayfası 
        public async Task<IActionResult> JobTitle()
        {
            IEnumerable<JobTitle> jobTitles = await _jobTitleRepository.GetListAsync();
            return View(jobTitles);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobTitle(JobTitle model)
        {
            await _jobTitleRepository.AddAsync(model);
            await _jobTitleRepository.SaveAsync();
            return RedirectToAction("JobTitle");
        }

        public async Task<IActionResult> RemoveJobTitle(int id)
        {
            bool result = await _jobTitleRepository.RemoveAsync(id);
            await _jobTitleRepository.SaveAsync();
            return RedirectToAction("JobTitle");
        }


        // DeedStatus Tapu durumu sayfası
        public async Task<IActionResult> DeedStatus()
        {
            IEnumerable<DeedStatus> deedStatuses = await _deedStatusRepository.GetListAsync();
            return View(deedStatuses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeedStatus(DeedStatus model)
        {
            await _deedStatusRepository.AddAsync(model);
            await _deedStatusRepository.SaveAsync();
            return RedirectToAction("DeedStatus");
        }

        public async Task<IActionResult> RemoveDeedStatus(int id)
        {
            bool result = await _deedStatusRepository.RemoveAsync(id);
            await _deedStatusRepository.SaveAsync();
            return RedirectToAction("DeedStatus");
        }

        // HeatingType ısıtma tipi sayfası 
        public async Task<IActionResult> HeatingType()
        {
            IEnumerable<HeatingType> heatingTypes = await _heatingTypeRepository.GetListAsync();
            return View(heatingTypes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHeatingType(HeatingType model)
        {
            await _heatingTypeRepository.AddAsync(model);
            await _heatingTypeRepository.SaveAsync();
            return RedirectToAction("HeatingType");
        }

        public async Task<IActionResult> RemoveHeatingType(int id)
        {
            bool result = await _heatingTypeRepository.RemoveAsync(id);
            await _heatingTypeRepository.SaveAsync();
            return RedirectToAction("HeatingType");
        }

        // InternetType internet tipi sayfası 
        public async Task<IActionResult> InternetType()
        {
            IEnumerable<InternetType> internetTypes = await _internetTypeRepository.GetListAsync();
            return View(internetTypes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInternetType(InternetType model)
        {
            await _internetTypeRepository.AddAsync(model);
            await _internetTypeRepository.SaveAsync();
            return RedirectToAction("InternetType");
        }

        public async Task<IActionResult> RemoveInternetType(int id)
        {
            bool result = await _internetTypeRepository.RemoveAsync(id);
            await _internetTypeRepository.SaveAsync();
            return RedirectToAction("InternetType");
        }

        // PropertyType mülk tipi sayfası 
        public async Task<IActionResult> PropertyType()
        {
            IEnumerable<PropertyType> allModels = await _propertyTypeRepository.GetListAsync();
            return View(allModels);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePropertyType(PropertyType model)
        {
            await _propertyTypeRepository.AddAsync(model);
            await _propertyTypeRepository.SaveAsync();
            return RedirectToAction("PropertyType");
        }

        public async Task<IActionResult> RemovePropertyType(int id)
        {
            bool result = await _propertyTypeRepository.RemoveAsync(id);
            await _propertyTypeRepository.SaveAsync();
            return RedirectToAction("PropertyType");
        }

        // Status durumu sayfası 
        public async Task<IActionResult> Status()
        {
            IEnumerable<Status> allModels = await _statusRepository.GetListAsync();
            return View(allModels);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStatus(Status model)
        {
            await _statusRepository.AddAsync(model);
            await _statusRepository.SaveAsync();
            return RedirectToAction("Status");
        }

        public async Task<IActionResult> RemoveStatus(int id)
        {
            bool result = await _statusRepository.RemoveAsync(id);
            await _statusRepository.SaveAsync();
            return RedirectToAction("Status");
        }

        // UsingStatus kullanım durumu sayfası 
        public async Task<IActionResult> UsingStatus()
        {
            IEnumerable<UsingStatus> allModels = await _usingStatusRepository.GetListAsync();
            return View(allModels);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsingStatus(UsingStatus model)
        {
            await _usingStatusRepository.AddAsync(model);
            await _usingStatusRepository.SaveAsync();
            return RedirectToAction("UsingStatus");
        }

        public async Task<IActionResult> RemoveUsingStatus(int id)
        {
            bool result = await _usingStatusRepository.RemoveAsync(id);
            await _usingStatusRepository.SaveAsync();
            return RedirectToAction("UsingStatus");
        }


        // About Hakkımızda sayfası
        public async Task<IActionResult> About()
        {
            var abouts = await _aboutRepository.GetListAsync();
            return View(abouts.First());
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(About model)
        {
            About about = await _aboutRepository.GetAsync(x => x.Id == model.Id);
            about.Title = model.Title;
            about.BodyTitle = model.BodyTitle;
            about.BodyContentA = model.BodyContentA;
            about.BodyContentB = model.BodyContentB;
            await _aboutRepository.SaveAsync();
            SuccessAlert("Hakkımızda sayfası güncellendi");
            return RedirectToAction("About");
        }


        // Contact İletişim sayfası
        public async Task<IActionResult> Contact()
        {
            var contacts = await _contactRepository.GetListAsync();
            return View(contacts.First());
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact", model);
            }

            Contact contact = await _contactRepository.GetAsync(x => x.Id == model.Id);
            contact.HeaderDescription = model.HeaderDescription;
            contact.GoogleIFrameUrl = model.GoogleIFrameUrl;
            contact.Email = model.Email;
            contact.PhoneNumber = model.PhoneNumber;
            contact.InstagramUrl = model.InstagramUrl;
            contact.FacebookUrl = model.FacebookUrl;
            contact.LinkedInUrl = model.LinkedInUrl;
            contact.TwitterUrl = model.TwitterUrl;
            await _contactRepository.SaveAsync();
            SuccessAlert("İletişim sayfası güncellendi");
            return RedirectToAction("Contact");
        }

        // Agent Danışman veya kullanıcı sayfası
        public IActionResult Agent()
        {
            var agents = _agentRepository.GetListAgentDto();
            IEnumerable<AgentVM> vm = _mapper.Map<IEnumerable<AgentVM>>(agents);
            return View(vm);
        }

        public IActionResult AgentAdd()
        {
            SelectItemInitializeAgent();
            return View();
        }

        public async Task<IActionResult> RemoveAgent(int id)
        {
            await _agentRepository.RemoveAsync(id);
            await _agentRepository.SaveAsync();
            SuccessAlert("Silindi");
            return RedirectToAction("Agent");
        }

        public IActionResult AgentUpdate(int? id)
        {
            SelectItemInitializeAgent();
            if (id is not null)
            {
                AgentDto agent = _agentRepository.GetAgentDto(id);
                AgentVM vm = _mapper.Map<AgentVM>(agent);

                return View(vm);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAgent(AgentVM model)
        {
            Agent agent = await _agentRepository.GetAsync(x => x.Id == model.Id);
            if (model.ProfilePhoto != null)
            {
                if (agent.ProfilePhotoPath.Contains("/img/"))
                {
                    agent.ProfilePhotoPath = FileHelper.Add(model.ProfilePhoto);
                }
                else
                {
                    agent.ProfilePhotoPath = FileHelper.Update(agent.ProfilePhotoPath, model.ProfilePhoto);
                }
            }
            agent.FirstName = model.FirstName;
            agent.LastName = model.LastName;
            agent.Email = model.Email;
            agent.MobileNumber = model.MobileNumber;
            agent.PhoneNumber = model.PhoneNumber;
            agent.Description = model.Description;
            agent.FacebookLink = model.FacebookLink;
            agent.InstagramLink = model.InstagramLink;
            agent.JobTitle = model.JobTitleId;
            agent.LinkedinLink = model.LinkedinLink;
            agent.TwitterLink = model.TwitterLink;
            agent.YoutubeLink = model.YoutubeLink;
            if (await _agentRepository.GetCountAsync(x => x.IsFavoritUser) <= 3)
            {
                agent.IsFavoritUser = model.IsFavoritUser;
            }
            await _agentRepository.SaveAsync();
            SuccessAlert("Güncellendi");
            return RedirectToAction("Agent");
        }

        //Propety Mülk sayfası
        public async Task<IActionResult> Property()
        {
            IEnumerable<PropertyDto> properties = _propertyRepository.GetListPropertyDto();
            IEnumerable<PropertyVM> vm = _mapper.Map<IEnumerable<PropertyVM>>(properties);
            return View(vm);
        }

        public IActionResult PropertyAdd()
        {
            SelectItemInitializeProperty();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProperty(PropertyVM model)
        {
            // property add
            Property property = _mapper.Map<Property>(model);
            if (property.KonumIFrame is null)
            {
                property.KonumIFrame = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d192697.79327595135!2d28.8720964464606!3d41.00549580940238!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caa7040068086b%3A0xe1ccfe98bc01b0d0!2zxLBzdGFuYnVs!5e0!3m2!1str!2str!4v1651089326725!5m2!1str!2str";

            }
            var entity = await _propertyRepository.AddAsync(property);
            var save = await _propertyRepository.SaveAsync();

            // propety photos add
            List<string> paths = await FileHelper.AddAllAsync(model.PropertyPhotos, entity.Id.ToString());
            List<PropertyPhoto> propertyPhotos = new List<PropertyPhoto>();
            foreach (var item in paths)
            {
                PropertyPhoto propertyPhoto = new PropertyPhoto()
                {
                    PropertyId = entity.Id,
                    Path = item
                };
                propertyPhotos.Add(propertyPhoto);
            }
            if (await _propertyPhotoRepository.GetCountAsync(x => x.PropertyId == entity.Id) == 0)
            {
                propertyPhotos[0].BasePhoto = true;
            }
            await _propertyPhotoRepository.AddRangeAsync(propertyPhotos);
            await _propertyPhotoRepository.SaveAsync();
            SuccessAlert("Mülk eklendi");
            return RedirectToAction("Property");
        }
        public async Task<IActionResult> RemoveProperty(int id)
        {
            var photoPaths = await _propertyPhotoRepository.GetListAsync(x => x.PropertyId == id);
            if (photoPaths is not null)
            {
                foreach (var item in photoPaths)
                {
                    FileHelper.Delete(item.Path);
                    await _propertyPhotoRepository.RemoveAsync(item.Id);
                    await _propertyPhotoRepository.SaveAsync();
                }
            }

            await _propertyRepository.RemoveAsync(id);
            await _propertyRepository.SaveAsync();
            SuccessAlert("Silindi");
            return RedirectToAction("Property");
        }


        ////// Sayfa property add içine gömüldü 
        // public async Task<IActionResult> PropertyPhoto(int id)
        // {
        //     PropertyPhotoVM model = new PropertyPhotoVM();
        //     model.PropertyId = id;
        //     return View(model);
        // }



        // [HttpPost]
        // public async Task<IActionResult> AddPropertyPhoto(PropertyPhotoVM model){
        //     List<string> paths = await FileHelper.AddAllAsync(model.PropertyPhotos,model.PropertyId.ToString());
        //     List<PropertyPhoto> propertyPhotos = new List<PropertyPhoto>();
        //     foreach (var item in paths)
        //     {   
        //         PropertyPhoto propertyPhoto = new PropertyPhoto(){
        //             PropertyId = model.PropertyId,
        //             Path = item
        //         };
        //         propertyPhotos.Add(propertyPhoto);
        //     }
        //     if (await _propertyPhotoRepository.GetCountAsync(x=>x.PropertyId==model.PropertyId) == 0)
        //     {
        //         propertyPhotos[0].BasePhoto = true;
        //     }
        //     await _propertyPhotoRepository.AddRangeAsync(propertyPhotos);
        //     await _propertyPhotoRepository.SaveAsync();
        //     SuccessAlert("Resimler eklendi");
        //     return RedirectToAction("Property");
        // }



        // başlangıç yükleme fonksiyonları
        private void SelectItemInitializeAgent()
        {
            var jobTitles = _jobTitleRepository.GetList();
            IEnumerable<SelectListItem> selectJobTitles = jobTitles.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            ViewData.Add("JobTitles", selectJobTitles);
        }

        private void SelectItemInitializeProperty()
        {
            IEnumerable<SelectListItem> selectIl = _cityRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });

            IEnumerable<SelectListItem> selectPropertyType = _propertyTypeRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            IEnumerable<SelectListItem> selectStatus = _statusRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            IEnumerable<SelectListItem> selectHeatingType = _heatingTypeRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            IEnumerable<SelectListItem> selectInternetType = _internetTypeRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            IEnumerable<SelectListItem> selecFront = _frontRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            IEnumerable<SelectListItem> selectUseStatus = _usingStatusRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            IEnumerable<SelectListItem> selectDeedStatus = _deedStatusRepository.GetList().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            IEnumerable<SelectListItem> selectAgent = _agentRepository.GetListAgentDto().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = $"{x.FirstName} {x.LastName}"
            });

            ViewData.Add("Cities", selectIl);
            ViewData.Add("PropertyTypes", selectPropertyType);
            ViewData.Add("Statuses", selectStatus);
            ViewData.Add("HeatingTypes", selectHeatingType);
            ViewData.Add("InternetTypes", selectInternetType);
            ViewData.Add("Fronts", selecFront);
            ViewData.Add("UsingStatus", selectUseStatus);
            ViewData.Add("DeedStatus", selectDeedStatus);
            ViewData.Add("Agents", selectAgent);

        }

        public IActionResult SelectItemDistrict(int id)
        {
            int key = _cityRepository.Get(x => x.Id == id).Key;
            IEnumerable<SelectListItem> selectIlce = _districtRepository.GetList(x => x.IlKey == key).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            return Json(selectIlce);
        }

        public IActionResult SelectItemNeighborhood(int id)
        {
            int key = _districtRepository.Get(x => x.Id == id).Key;
            IEnumerable<SelectListItem> selectMahalle = _neighborhoodRepository.GetList(x => x.IlceKey == key).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            return Json(selectMahalle);

        }
        public IActionResult SelectItemStreet(int id)
        {
            int key = _neighborhoodRepository.Get(x => x.Id == id).Key;
            IEnumerable<SelectListItem> selectSokak = _streetRepository.GetList(x => x.MahalleKey == key).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            return Json(selectSokak);
        }
    }
}
