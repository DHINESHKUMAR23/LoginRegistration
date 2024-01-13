using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginRegistration.Models;
using System.Web.Security;



namespace LoginRegistration.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Welcome()
        {
            ViewBag.Message = "Login Successful";

            return View();
        }




        [HttpPost]
        public ActionResult Register(AdminDetail model)
        {
            using (var context = new StudentDBEntities4())
            {
                context.AdminDetails.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }



        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }



        // GET: Account
        public ActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Login(Models.AdminDetail model)
        {
            using (var context = new StudentDBEntities4())
            {
                bool isValid = context.AdminDetails.Any(x => x.Email == model.Email && x.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Welcome");



                }
                ModelState.AddModelError("", "Invalid username and password");
                return View();
            }

        }
    }
}
