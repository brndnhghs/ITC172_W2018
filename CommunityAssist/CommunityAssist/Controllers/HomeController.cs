using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist.Models;

namespace CommunityAssist.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // add ref to Entities
            CommunityAssist2017Entities db = new CommunityAssist2017Entities();
            //return list
            return View(db.GrantTypes.ToList());
        
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}