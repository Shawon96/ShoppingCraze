using ShoppingCraze.BLL.Interfaces;
using ShoppingCraze.DAL.Interfaces;
using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCraze.BLL.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository) : base(repository)
        { }
    }
}
