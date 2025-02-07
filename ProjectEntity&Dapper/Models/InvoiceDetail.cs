using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity_Dapper.Models
{
    public class InvoiceDetail
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceDetailId { get; set; }


        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => Quantity * UnitPrice;



        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public virtual Invoicess Invoice { get; set; }
       


        [ForeignKey("product")]
        public int ProductId { get; set; }
        public virtual Product product { get; set; }


    }
}
