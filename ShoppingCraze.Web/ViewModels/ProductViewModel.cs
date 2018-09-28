using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCraze.Web.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Category> Categories{ get; set; }
        public IEnumerable<Product> AllProducts { get; set; }
        //public IEnumerable<int> CategoriesIds { get; set; }
    }
}