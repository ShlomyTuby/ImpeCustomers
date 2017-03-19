using ImpeCustomers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImpeCustomers.Services
{
    public class NavigationService
    {

        public static ICollection<Navigation> GetNavigations()
        {
            var result = new List<Navigation>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                result = db.Navigations.Where(n => n.IsRoot == true)
                    .OrderBy(n => n.Index)
                    .ToList();
            }

            return result;
        }

        public static ICollection<Navigation> GetNavigations(int parentId)
        {
            var result = new List<Navigation>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                result = db.Navigations.Where(n => n.ParentId == parentId)
                    .OrderBy(n => n.Index)
                    .ToList();
            }

            return result;
        }

    }
}