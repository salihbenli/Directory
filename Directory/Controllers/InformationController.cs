using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Directory.Controllers
{
    public class InformationController : Controller
    {
        InformationManager _informationManager = new InformationManager();
        ContactManager _contactManager = new ContactManager();
        DataSet dataTable = new DataSet();
        Context system = new Context();

        public ActionResult Info()
        {
            return View();
        }
        public ActionResult liste(string location)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select Location, count(distinct UUID)kisi_sayisi, count(distinct Telephone_Number)telefon from Informations where Location = '" + location + "' group by Location order by kisi_sayisi desc", system.baglan());
            cmd.Fill(dataTable, "liste");
            var rapor = JsonConvert.SerializeObject(dataTable.Tables["liste"]);
            system.baglan().Close();
            return Json(rapor);
        }



        public ActionResult Report()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select Location, count(distinct UUID)kisi_sayisi, count(distinct Telephone_Number)telefon from Informations where Location = Location group by Location order by kisi_sayisi desc", system.baglan());
            cmd.Fill(dataTable, "liste");
            var rapor = JsonConvert.SerializeObject(dataTable.Tables["liste"]);
            system.baglan().Close();
            return Json(rapor);
        }

        public IActionResult InfoList(int id)
        {
            var result = _informationManager.GetListByID(id);
            return View(result);
        }

        [HttpGet]
        public ActionResult InfoAdd(int id)
        {
            List<SelectListItem> valueId = (from x in _contactManager.GetListByID(id)
                                            select new SelectListItem
                                            {
                                                Text = x.Name + " " + x.LastName,
                                                Value = x.UUID.ToString()
                                            }).ToList();

            ViewBag.vlc = valueId;
            return View();
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
