using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week5CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            Models.ContactInfo cf = new Models.ContactInfo();
            return View(cf);
        }

        // POST: /Contact/

        public ActionResult Index(Models.ContactInfo cf)
        {
            //creat a new connection to database
            Models.Week5CodeChallengeEntities3 db = new Models.Week5CodeChallengeEntities3();
            //add contact info to database
            db.ContactInfoes.Add(cf);
            //save changes
            db.SaveChanges();

            return View();
        }

    }
}
