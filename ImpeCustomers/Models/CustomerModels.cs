using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImpeCustomers.Models
{
    public class Customer
    {
        public Customer()
        {
            TimeCreated = DateTime.Now;
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Comments { get; set; }
        public string ContactUserId { get; set; }
        virtual public ApplicationUser ContactUser { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}