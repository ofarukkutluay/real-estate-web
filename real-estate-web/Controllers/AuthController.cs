using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database;
using real_estate_web.Models.ViewModel;
using real_estate_web.Tools.Hashing;
using real_estate_web.Tools.Results;
using real_estate_web.Tools.TokenOperations;
using real_estate_web.Tools.TokenOperations.Models;

namespace real_estate_web.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IAgentRepository _agentRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AuthController(IAgentRepository agentRepository, IConfiguration configuration, IMapper mapper)
        {
            _agentRepository = agentRepository;
            _configuration = configuration;
            _mapper = mapper;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserVM model)
        {
            if (!ModelState.IsValid)
                return View();
            Agent agent = await _agentRepository.GetAsync(x => x.Email == model.Email);
            if (agent is null)
            {
                DangerAlert("kullanıcı bulunamadı!");
                return View();
            }

            if (!HashingHelper.VerifyPasswordHash(model.Password, agent.PassSalt, agent.PassHash))
            {
                InfoAlert("Şifre hatalı!");
                return View();
            }

            TokenHandler tokenHandler = new TokenHandler(_configuration);
            Token token = tokenHandler.CreateAccessToken(agent);
            agent.RefreshToken = token.RefreshToken;
            agent.RefresTokenExpireDate = token.Expiration.AddMinutes(5);
            _agentRepository.Update(agent);
            _agentRepository.SaveChanges();

            HttpContext.Session.SetString("Token",token.AccessToken);

            return RedirectToAction("Index","Admin");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserVM model)
        {

            byte[] passHash, passSalt;
            Agent agent = await _agentRepository.GetAsync(x => x.Email == model.Email);
            if (agent is not null)
            {
                DangerAlert("Kullanıcı zaten mevcut!");
                return View();
            }
            HashingHelper.CreatePasswordHash(model.Password, out passSalt, out passHash);
            agent = new Agent()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                MobileNumber = "90"+model.MobileNumber,
                JobTitle = model.JobTitleId,
                Role = model.Role,
                PassHash = passHash,
                PassSalt = passSalt,
            };

            if(await _agentRepository.GetCountAsync(x=>x.Role == Role.Admin) <= 0)
            {
                agent.Role = Role.Admin;
            }

            await _agentRepository.AddAsync(agent);
            int result = await _agentRepository.SaveAsync();
            SuccessAlert("Kayıt Başarılı!");
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public IActionResult Logout(){
            HttpContext.Session.Remove("Token");
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
