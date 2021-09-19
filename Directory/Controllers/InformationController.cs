using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Directory.Controllers
{
    public class InformationController : Controller
    {
        InformationManager _informationManager = new InformationManager();
        ContactManager _contactManager = new ContactManager();

        [HttpGet]
        public IActionResult Info(string location = null)
        {
            var result = _informationManager.GetListLocation(location);
            ViewBag.location = location;
            return View(result);
        }

        public IActionResult InfoList(int id)
        {
            var result = _informationManager.GetListByID(id);
            return View(result);
        }

        [HttpGet]
        public ActionResult InfoAdd(int id)
        {
            var contactResult = _contactManager.GetByID(id);
            var infoResult = _informationManager.GetList();
            if (infoResult.Count != 0)
            {
                var infoadd = infoResult.Find(x => x.UUID == contactResult.UUID);
                return View(infoadd);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult InfoAdd(Information information)
        {
            _informationManager.InformationAdd(information);
            return RedirectToAction("Contact", "Contact");
        }

        public ActionResult InfoDelete(int id)
        {
            var infoDelete = _informationManager.GetByID(id);
            _informationManager.InformationDelete(infoDelete);
            return RedirectToAction("Contact", "Contact");
        }

        [HttpGet]
        public ActionResult InfoUpdate(int id)
        {
            var infoUpdate = _informationManager.GetByID(id);
            return View(infoUpdate);
        }
        [HttpPost]
        public ActionResult InfoUpdate(Information information)
        {
            _informationManager.InformationUpdate(information);
            return RedirectToAction("Contact", "Contact");
        }

    }
}
