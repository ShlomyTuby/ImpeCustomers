using ImpeCustomers.Models;
using ImpeCustomers.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImpeCustomers.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            
        }
        
        [Authorize]
        public ActionResult Index()
        {
            return View();
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

        [Authorize]
        public ActionResult Profile()
        {
            ViewBag.Message = "Your profile page.";

            var userId = User.Identity.GetUserId();

            UserManager<ApplicationUser> userManager;
            Customer customer;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                customer = db.Customers.Where( c => c.ContactUser.Id == userId ).Include(c => c.ContactUser).FirstOrDefault();
                userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                ViewBag.Logins = userManager.GetLogins(userId).Select(l => l.LoginProvider).ToList();
            }

            
            return View(customer);

           
        }
        
    }
}