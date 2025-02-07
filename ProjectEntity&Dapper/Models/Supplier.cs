using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity_Dapper.Models
{
    public class Supplier
    {

        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Adress { get; set; }
        public string? Note { get; set; }


        public string Company { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? PhoneNumber { get; set; }
        public bool? isActive { get; set; }
        public string? Image { get; set; }
    }
}



