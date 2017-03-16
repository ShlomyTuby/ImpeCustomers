using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImpeCustomers.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ShortName { get; set; }
        public string GeoName { get; set; }
        public Country Country { get; set; }
    }
}