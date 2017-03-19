using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImpeCustomers.Models
{
    public class Navigation
    {
        public Navigation()
        {
            Childrens = new List<Navigation>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        public bool IsRoot { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; }
        virtual public Navigation Parent { get; set; }

        [ForeignKey("ParentId")]
        virtual public ICollection<Navigation> Childrens { get; set; }

        
    }
}