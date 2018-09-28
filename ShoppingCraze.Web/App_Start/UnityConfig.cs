using ShoppingCraze.BLL.Interfaces;
using ShoppingCraze.BLL.Services;
using ShoppingCraze.DAL.Contexts;
using ShoppingCraze.DAL.Interfaces;
using ShoppingCraze.DAL.Repositories;
using System.Data.Entity;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ShoppingCraze.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Add mappings here
            // Context
            container.RegisterType<DbContext, CRSContext>();

            // Repositories
            container.RegisterType<IAdminRepository, AdminRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IProductRepositoty, ProductRepository>();
            //container.RegisterType<ICourseRepository, CourseRepository>();
            //container.RegisterType<IProgramCourseAssociationRepository, ProgramCourseAssociationRepository>();
            //container.RegisterType<IPrerequisiteRepository, PrerequisiteRepository>();
            //container.RegisterType<IStudentRepository, StudentRepository>();
            //container.RegisterType<IStudentCourseAssociationRepository, StudentCourseAssociationRepository>();
            //container.RegisterType<IExamScheduleRepository, ExamScheduleRepository>();
            //container.RegisterType<IWarehouseRepository, WarehouseRepository>();

            // Services
            container.RegisterType<IAdminService, AdminService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IProductService, ProductService>();
            //container.RegisterType<ICourseService, CourseService>();
            //container.RegisterType<IProgramCourseAssociationService, ProgramCourseAssociationService>();
            //container.RegisterType<IPrerequisiteService, PrerequisiteService>();
            //container.RegisterType<IStudentService, StudentService>();
            //container.RegisterType<IStudentCourseAssociationService, StudentCourseAssociationService>();
            //container.RegisterType<IExamScheduleService, ExamScheduleService>();
            //container.RegisterType<IWarehouseService, WarehouseService>();
            //container.RegisterType<IRecommendationService, RecommendationService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}