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
    public class Category : BaseEntity
    {
        // Database fields
        [Column("CategoryId")]
        [Key]
        public override int Id { get; set; }
        public string CategoryName { get; set; }

        // Navigation properties
        public virtual ICollection<Product> Products { get; set; }
    }
}