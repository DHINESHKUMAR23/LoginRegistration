using LoginRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginRegistration.Controllers
{
    public class ApplyController : Controller
    {
        // GET: Default
        public ActionResult Apply()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Apply(Application model)
        {
            using (var context = new StudentDBEntities4())
            {
                context.Applications.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("About","Home");
        }
    }
}