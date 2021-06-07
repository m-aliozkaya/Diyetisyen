using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Data;
using WebUI.Models;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private UserManager _userManager;

        public AccountController()
        {
            _userManager = new UserManager();
        }

        public ActionResult Login()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(LoginModel model, string ReturnUrl)
        {

            if (ModelState.IsValid)
            {
                Claims claim = _userManager.Login(model.UserName, model.Password);

                if (claim != Claims.Null)
                {
                    Session["role"] = claim;
                    Session["userName"] = model.UserName;

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                } else
                {
                    ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Yanlış");
                }

            }

            return View(model);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}