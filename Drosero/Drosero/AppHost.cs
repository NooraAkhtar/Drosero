using Funq;
using ServiceStack;
using Drosero.ServiceInterface;
using Drosero.Domain.Services;
using Drosero.Domain.Models;
using Drosero.Domain.Interfaces;
using Drosero.Domain.Repositories;
using ServiceStack.Api.Swagger;

namespace Drosero
{
    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("Drosero", typeof(AppServices).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());

            this.Plugins.Add(new SwaggerFeature());

            container.RegisterAutoWiredAs<CategoryService<Category>, CategoryService<Category>>();
            container.RegisterAutoWiredAs<FoodItemService<FoodItem>, IFoodItemService<FoodItem>>();

            container.RegisterAutoWiredAs<FoodItemRepository<FoodItem>, IFoodItemRepository<FoodItem>>();
            container.RegisterAutoWiredAs<CategoryRepository<Category>, ICategoryRepository<Category>>();

        }
    }
}