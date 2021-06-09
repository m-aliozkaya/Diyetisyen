using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Data;
using WebUI.Entity;
using WebUI.Entity.Diets.Abstract;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                return View();         
        }

        public ActionResult Dieticians()
        {
            List<Dietician> dieticianList = InMemory.Memory.GetDieticians();
            return View(dieticianList);
        }

        public ActionResult Diets()
        {
            List<Diet> dietList = InMemory.Memory.GetDiets();
            return View(dietList);
        }

        public ActionResult Contact()
        {
            return View();
        }

        
    }
}