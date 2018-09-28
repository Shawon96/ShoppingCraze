using ShoppingCraze.DAL.Interfaces;
using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCraze.DAL.Repositories
{
   public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
