using ShoppingCraze.DAL.Interfaces;
using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ShoppingCraze.DAL.Repositories
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(DbContext dbContext) : base(dbContext)
        { }
    }
}
