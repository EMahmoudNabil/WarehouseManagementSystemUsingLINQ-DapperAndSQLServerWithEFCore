using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEntity_Dapper.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity {  get; set; }
        public string? Note { get; set; }
        public string? Image { get; set; }

        [ForeignKey("Category")]
        public int catid { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
