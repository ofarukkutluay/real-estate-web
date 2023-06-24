using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database;
using real_estate_web.Models.HelperEntities;
using real_estate_web.Models.ViewModel;
using real_estate_web.Tools.Hashing;
using real_estate_web.Tools.Results;
using real_estate_web.Tools.TokenOperations;
using real_estate_web.Tools.TokenOperations.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

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
            Agent agent = await _agentRepository.GetAsync(x => x.Email == model.Email.Trim());
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
            Agent agent = await _agentRepository.GetAsync(x => x.Email == model.Email.Trim());
            if (agent is not null)
            {
                DangerAlert("Kullanıcı zaten mevcut!");
                return Redirect(Request.Headers["Referer"].ToString());
            }
            HashingHelper.CreatePasswordHash(model.Password, out passSalt, out passHash);

            model.MobileNumber = model.MobileNumber.Trim().Replace(" ", "");

            if (!Regex.IsMatch(model.MobileNumber, @"^([5]{1})([0-9]{9})$"))
            {
                DangerAlert("Cep telefonunu hatalı girdiniz");
                return Redirect(Request.Headers["Referer"].ToString());
            }


            agent = new Agent()
            {
                FirstName = model.FirstName.Trim(),
                LastName = model.LastName.Trim(),
                Email = model.Email.Trim(),
                MobileNumber = model.MobileNumber,
                JobTitle = model.JobTitleId,
                PassHash = passHash,
                PassSalt = passSalt,
            };

            if(model.Role is not null)
                agent.Role = model.Role;

            if(await _agentRepository.GetCountAsync(x=>x.Role == Roles.Admin) <= 0)
            {
                agent.Role = Roles.Admin;
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
