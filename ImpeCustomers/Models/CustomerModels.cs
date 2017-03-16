using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImpeCustomers.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Comments { get; set; }
        public IEnumerable<ApplicationUser> ContactUsers { get; set; }
    }
}