using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity_Dapper.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(15)]
        public string? PhoneNumber { get; set; }
        [StringLength(50)]
        public string? Email {  get; set; }
        [StringLength(250)]
        public string? Address { get; set; }

        [StringLength(50)]
        public string? City { get; set; }
        [StringLength(50)]
        public string? Country { get; set; }
      
        public bool? isActive { get; set; }
        public string? Notes { get; set; }



        public virtual List<Invoicess> invoice { get; } = new List<Invoicess>();


    }
}
