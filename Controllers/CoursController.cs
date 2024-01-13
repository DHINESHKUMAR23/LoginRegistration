using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers
{
    public class CoursController : Controller
    {
        private StudentDBEntities4 db = new StudentDBEntities4();

        // GET: Cours
        public ActionResult Index()
        {
            return View(db.Courses.ToList());
        }

        // GET: Cours/Details/5
       
        // GET: Cours/Create
       
        // POST: Cours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        

        // GET: Cours/Edit/5
       

        // POST: Cours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.


        // GET: Cours/Delete/5
      

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
