using System.Web.Mvc;
using Drosero.Domain.Interfaces;
using Unity;
using Drosero.Domain.Models;
using Drosero.Domain.Repositories;
using Drosero.Domain.Services;

namespace DroseroMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
			

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();


            container.RegisterType(typeof(ICategoryService<Category>), typeof(CategoryService<Category>));
            container.RegisterType(typeof(IFoodItemService<FoodItem>), typeof(FoodItemService<FoodItem>));

            container.RegisterType(typeof(ICategoryRepository<Category>), typeof(CategoryRepository<Category>));
            container.RegisterType(typeof(IFoodItemRepository<FoodItem>),typeof(FoodItemRepository<FoodItem>));
                                                                       
        }

        private static void RegisterInstances(UnityContainer container)
        {
           
        }
    }
}