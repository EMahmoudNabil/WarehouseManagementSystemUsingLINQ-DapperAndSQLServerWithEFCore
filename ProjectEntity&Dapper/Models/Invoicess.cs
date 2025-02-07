using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity_Dapper.Models
{
    public class Invoicess
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // إذا كان InvoiceId Identity
        public int InvoiceId { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceNumber { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [StringLength(250)]
        public string? Notes { get; set; }

        public decimal TotalAmount { get; set; }


        [Required]
   

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customers Customer { get; set; }



       
     
        public virtual List<InvoiceDetail> InvoiceDetails { get; } = new List<InvoiceDetail>();



       


      

    }
}
