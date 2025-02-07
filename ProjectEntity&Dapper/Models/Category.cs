using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity_Dapper.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public virtual List<Products> Products { get; set; } 

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
