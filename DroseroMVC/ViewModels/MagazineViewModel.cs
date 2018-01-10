using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroseroMVC.ViewModels
{
    public class MagazineViewModel
    {
        public CategoryViewModel CategoryViewModel { get; set; }

        private string pageTitle;
        public string PageTitle
        {
            get
            {
                pageTitle  = "Categories";
                if (CategoryViewModel != null && CategoryViewModel.Categories != null)
                {
                    pageTitle = CategoryViewModel.Categories.FirstOrDefault().Name;
                }
                return pageTitle;
            }
            set { pageTitle = value; }
        }

        public FoodItemViewModel CartItemsViewModel { get; set; } = new FoodItemViewModel();

        public string ErrorMessage { get; set; }
    }
}