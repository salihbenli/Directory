using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Directory.Controllers
{
    public class InformationController : Controller
    {
        InformationManager _informationManager = new InformationManager();
        ContactManager _contactManager = new ContactManager();
        public IActionResult Info()
        {
            return View();
        }

        public IActionResult InfoList(int id)
        {
            var result = _informationManager.GetListByID(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult InfoAdd(int id)
        {
            var result = _contactManager.GetByID(id);
            return View();
        }
        [HttpPost]
        public ActionResult InfoAdd(Information information)
        {
            _informationManager.InformationAdd(information);
            return RedirectToAction();
        }

        public ActionResult InfoDelete(int id)
        {
            var infoDelete = _informationManager.GetByID(id);
            _informationManager.InformationDelete(infoDelete);
            return View("Info");
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
            return RedirectToAction();
        }

    }
}
