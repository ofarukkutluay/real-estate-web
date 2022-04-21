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
        private readonly IMapper _mapper;
        public AdminController(IJobTitleRepository jobTitleRepository, IAboutRepository aboutRepository,
                                    IContactRepository contactRepository, IAgentRepository agentRepository, IDeedStatusRepository deedStatusRepository,
                                    IHeatingTypeRepository heatingTypeRepository, IInternetTypeRepository internetTypeRepository, IPropertyTypeRepository propertyTypeRepository,
                                    IStatusRepository statusRepository, IUsingStatusRepository usingStatusRepository,IMapper mapper)
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
                return View("Contact",model);
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
            SelectItemInitialize();
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
            SelectItemInitialize();
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
            if (model.ProfilePhoto == null)
            {
                model.ProfilePhoto = new FormFile(null, -1, -1, "&&NotFound&&", "&&NotFound&&");
            }
            agent.ProfilePhotoPath = FileHelper.Add(model.ProfilePhoto);
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
            await _agentRepository.SaveAsync();
            SuccessAlert("Güncellendi");
            return RedirectToAction("Agent");
        }



        // başlangıç yükleme fonksiyonları
        private void SelectItemInitialize()
        {
            var jobTitles = _jobTitleRepository.GetList();
            IEnumerable<SelectListItem> selectJobTitles = jobTitles.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            ViewData.Add("JobTitles", selectJobTitles);
        }
    }
}
