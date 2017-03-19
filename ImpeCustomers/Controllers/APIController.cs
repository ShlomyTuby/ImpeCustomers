using ImpeCustomers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImpeCustomers.Controllers
{
    public class APIController : Controller
    {

        [HttpPost]
        public JsonResult GetCountries(string term)
        {
            if (string.IsNullOrEmpty(term))
            {
                term = "";
            }
            using (ApplicationDbContext db  = new ApplicationDbContext())
            {
                var result = db.Countries.Where(c => c.Name.ToLower().Contains(term.ToLower())).Select(r => new { name = r.Name, value = r.Name }).Take(10).ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult GetCities(string term, string country)
        {
            if (string.IsNullOrEmpty(term))
            {
                term = "";
            }
            if (string.IsNullOrEmpty(country))
            {
                country = "";
            }
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var result = db.Cities.Where(c => c.Name.ToLower().Contains(term.ToLower()) && ( String.IsNullOrEmpty(country) || c.Country.Name.ToLower().Contains(country.ToLower()) )).Select(r => new { name = r.Name, value = r.Name }).Take(10).ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }


        

    }
}