using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using FirstLook.Models;

// can use Firstlook.Models.MailingList



namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            MailingList m1 = new MailingList();
            m1.FirstName = "Brandon";
            m1.LastName = "Hughes";
            m1.Email = "brndnhghs@gmail.com";

            //TO HARDCODE IS not how you usually do it (usually from database)

            MailingList m2 = new MailingList();
            m2.FirstName = "Tandy";
            m2.LastName = "Fugs";
            m2.Email = "Tandy@gmail.com";

            MailingList m3 = new MailingList();
            m3.FirstName = "Blinklan";
            m3.LastName = "Habble";
            m3.Email = "BlinkHab@gmail.com";

            List<MailingList> mailingObjectList = new List<MailingList>();

            mailingObjectList.Add(m1);
            mailingObjectList.Add(m2);
            mailingObjectList.Add(m3);

            return View(mailingObjectList);
        }
    }
}