using ShoppingCraze.Entity.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCraze.Entity.Models
{
    public enum ProductStatus
    {
        Available, NotAvailable
    }
    public class Product : BaseEntity
    {
        // Database fields
        [Column("ProductId")]
        [Key]
        public override int Id { get; set; } 
        public string ProductName{ get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public ProductStatus productStatus { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Categories{ get; set; }
    }

}
