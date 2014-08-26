﻿using GoBlog.Areas.Admin.Models;
using GoBlog.Authentication;
using System.Web.Mvc;

namespace GoBlog.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticator authenticator;

        public LoginController(IAuthenticator authenticator)
        {
            this.authenticator = authenticator;
        }

        public ActionResult Index()
        {
            if (authenticator.Authenticated)
            {
                return Redirect();
            }

            return View();
        }

        public ActionResult Login(CredentialsModel model)
        {
            authenticator.Authenticate(model.Username, model.Password);

            if (authenticator.Authenticated)
            {
                return Redirect();
            }

            ModelState.AddModelError("", "Invalid username or password.");
            return View("Index", model);
        }

        public ActionResult Logout()
        {
            authenticator.Logout();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        private ActionResult Redirect()
        {
            if (Request.QueryString["ReturnUrl"] != null)
            {
                return Redirect(Request.QueryString["ReturnUrl"]);
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}