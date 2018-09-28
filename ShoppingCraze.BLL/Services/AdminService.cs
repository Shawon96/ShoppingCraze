using ShoppingCraze.BLL.Interfaces;
using ShoppingCraze.DAL.Interfaces;
using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCraze.BLL.Services
{
    public class AdminService : GenericService<Admin>, IAdminService
    {
        public AdminService(IAdminRepository repository) : base(repository)
        { }

    }
}
