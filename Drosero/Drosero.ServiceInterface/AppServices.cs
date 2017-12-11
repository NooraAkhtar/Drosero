using ServiceStack;
using Drosero.ServiceModel.Requests;
using Drosero.ServiceModel.Responses;
using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;

namespace Drosero.ServiceInterface
{
    public class AppServices : Service
    {
        private ICategoryService<Category> categoryService;
        private IFoodItemService<FoodItem> foodItemService;
        private IOrderService<Order> orderService;
        private IUserService<User> userService;

        public AppServices(ICategoryService<Category> categoryService,
            IFoodItemService<FoodItem> foodItemService,
            IOrderService<Order> orderService,
            IUserService<User> userService)
        {
            this.categoryService = categoryService;
            this.foodItemService = foodItemService;
            this.orderService = orderService;
            this.userService = userService;
        }

        public object Get(CategoryRequest request)
        {
            return new CategoryResponse { Category = categoryService.GetById(request.Id) };
        }

        public object Get(FoodItemRequest request)
        {
            return new FoodItemResponse { FoodItem = foodItemService.GetById(request.Id) };
        }
    }
}