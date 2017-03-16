using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImpeCustomers.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Code { get; set; }
        public string IOSCode { get; set; }
        public string GeoName { get; set; }
    }
}