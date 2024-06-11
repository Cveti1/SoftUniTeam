using Contacts.Contracts;
using Contacts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers
{
    public class ContactController : BaseController
    {
        private readonly IContactService service;

        public ContactController(IContactService _service)
        {
            service = _service;
        }


        public async Task<IActionResult> All()
        {
            var model = await service.GetAllContacts();

            return View(model);
        }



        [HttpGet]
        public async Task<IActionResult> Add()
        {
	        AddContactFormModel model = await service.GetAddContactModel();
	        return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddContactFormModel model)
        {
	        if (!ModelState.IsValid)
	        {
		        return View(model);
	        }

	        var userId = GetUserId();

	        await service.AddContact(model, userId);
	        return RedirectToAction(nameof(All));
        }


        public async Task<IActionResult> Team()
        {
            var model = await service.GetMyContacts(GetUserId());
            return View(model);
        }

        public async Task<IActionResult> AddToTeam(int id)
        {
            var contact = await service.GetContactById(id);

           if (contact == null)
            {
               return RedirectToAction("All", "Contact");
            }

            var userId = GetUserId();

            await service.AddContactToMy(userId, contact);
            return RedirectToAction(nameof(Team));
        }


    }
}


