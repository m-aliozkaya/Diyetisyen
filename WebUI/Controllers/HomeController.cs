using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Data;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["userName"] != null)
            {
                return View(Session["userName"]);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Dietician()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Diets()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //Session["sa"] = Claims.Patient;
            //Claims a = (Claims)Session["sa"] ;
            //if (a == Claims.Patient)
            //{
                
            //}
            return View();
        }

        
    }
}