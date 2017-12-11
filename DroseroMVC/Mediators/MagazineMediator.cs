using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using DroseroMVC.ViewModels;

namespace DroseroMVC.Mediators
{
    public class MagazineMediator
    {
        private ICategoryService<Category> categoryService;
        private IFoodItemService<FoodItem> foodItemService;

        public MagazineMediator(ICategoryService<Category> categoryService,
            IFoodItemService<FoodItem> foodItemService)
        {
            this.categoryService = categoryService;
            this.foodItemService = foodItemService;
        }

        public CategoryViewModel GetCategoryViewModel()
        {
            var categories = categoryService.GetAll();
            return new CategoryViewModel
            {
                Categories =  categories
            };
        }

        public FoodItemViewModel GetFoodItemsByCategory(int categoryId)
        {
            var foodItemViewModel = new FoodItemViewModel
            {
                FoodItems = foodItemService.GetFoodItemsByCategory(categoryId)
            };

            return foodItemViewModel;
        }
    }
}