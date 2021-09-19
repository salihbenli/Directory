using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Directory.Controllers
{
    public class ContactController : Controller
    {
        ContactManager _contactManager = new ContactManager();
        InformationManager _informationManager = new InformationManager();
        [HttpGet]
        public IActionResult Contact()
        {
            var result = _contactManager.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult ContactAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactAdd(Contact contact)
        {
            _contactManager.ContactAdd(contact);
            return RedirectToAction("Contact");
        }
        public ActionResult ContactDelete(int id)
        {
            var contactDelete = _contactManager.GetByID(id);
            _contactManager.ContactDelete(contactDelete);
            return RedirectToAction("Contact");
        }
        [HttpGet]
        public ActionResult ContactUpdate(int id)
        {
            var contactUpdate = _contactManager.GetByID(id);
            return View(contactUpdate);
        }
        [HttpPost]
        public ActionResult ContactUpdate(Contact contact)
        {
            _contactManager.ContactUpdate(contact);
            return RedirectToAction("Contact");
        }
    }
}
