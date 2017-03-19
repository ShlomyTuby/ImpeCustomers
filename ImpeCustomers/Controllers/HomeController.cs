﻿using ImpeCustomers.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImpeCustomers.Controllers
{
    
    public class HomeController : Controller
    {
        
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
            Customer customer;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                customer = db.Customers.FirstOrDefault( c => c.ContactUser.Id == userId );
            }

            return View(customer);
        }
    }
}