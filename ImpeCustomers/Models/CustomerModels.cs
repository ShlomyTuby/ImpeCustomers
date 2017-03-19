using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Comments { get; set; }
        public string ContactUserId { get; set; }
        [Display(Name = "Contact User")]
        virtual public ApplicationUser ContactUser { get; set; }
        [Display(Name = "Time Created")]
        public DateTime TimeCreated { get; set; }
    }
}