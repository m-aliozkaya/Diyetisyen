using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Data;
using WebUI.Entity;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class DieticianController : Controller
    {
        private UserManager _userManager;

        public DieticianController()
        {
            _userManager = new UserManager();
        }

        // GET: Dietician
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPatient()
        {
            ViewBag.DietId = new SelectList(InMemory.Memory.GetDiets(), "Name", "Description");
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddPatient(Patient patient)
        {

            if (ModelState.IsValid)
            {
                _userManager.AddPatient(patient);

                return RedirectToAction("/");
            }

            return View(patient);
        }

    }
}