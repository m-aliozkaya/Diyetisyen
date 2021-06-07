using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Data;
using WebUI.Entity;

namespace WebUI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["role"] != null)
            {
                Claims role = (Claims)Session["Role"];

                if (role != Claims.Admin)
                {
                    return RedirectToAction("Login", "Account", new { ReturnUrl = Request.Path });
                }

            }
            else
            {
                return RedirectToAction("Login", "Account", new { ReturnUrl = Request.Path });
            }

            List<Dietician> dieticianList = InMemory.Memory.GetDieticians();
            return View(dieticianList);
        }
    }
}