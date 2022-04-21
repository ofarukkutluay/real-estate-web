using Microsoft.AspNetCore.Mvc;
using real_estate_web.Data.Abstract;

namespace real_estate_web.Controllers
{
    public class ContactController : BaseController
    {

        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _contactRepository.GetListAsync();
            var contact = contacts.First();

            return View(contact);
        }


    }
}