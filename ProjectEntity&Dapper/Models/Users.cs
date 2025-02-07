using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity_Dapper.Models
{
    public class User
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(250)]
        public string? Adress { get; set; }
        public string? Image { get; set; }
        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string? Role { get; set; } = "User";




    }
}
