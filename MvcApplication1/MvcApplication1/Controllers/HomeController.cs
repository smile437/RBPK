using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Message = "Learn a foreign language easier than ever.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult StartLearn(int p=0)
        {
            /*List<UserProfile> users = new List<UserProfile>();
            string user = "";
            using (UsersContext db = new UsersContext())
            {
                user = db.Database.ExecuteSqlCommand("SELECT Name FROM UserProfile WHERE UserId=38").ToString();
                users = db.UserProfiles.Where(u => u.UserId == 37).ToList();
                /*Дописать свитч на запросы*/
            //}
           return View();
        }
        public ActionResult Chat() 
        {
            return View();
        }
    }
}
