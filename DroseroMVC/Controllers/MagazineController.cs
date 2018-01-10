using Drosero.Domain.Interfaces;
using DroseroMVC.Mediators;
using DroseroMVC.ViewModels;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Drosero.Domain.Models;
using Drosero.Domain.Repositories;
using Drosero.Domain.Services;
using Unity.Attributes;
using System;

namespace DroseroMVC.Controllers
{
    public class MagazineController : Controller
    {
        private MagazineMediator magazineMediator;
        private ICategoryService<Category> categoryService;
        IFoodItemService<FoodItem> foodItemService;
        public MagazineController(ICategoryService<Category> categoryService, IFoodItemService<FoodItem> foodItemService)
        {
            magazineMediator = new MagazineMediator(categoryService,foodItemService);
        }

        // GET: Magazine
        public ActionResult Index()
        {
            var viewModel = new MagazineViewModel { CategoryViewModel = new CategoryViewModel()};
            try
            {
                viewModel.CategoryViewModel = magazineMediator.GetCategoryViewModel();
            }
            catch (System.Exception e)
            {
                viewModel.ErrorMessage = e.Message;
            }
            return View(viewModel);
        }

        private string GetInnerException(Exception e)
        {
            var message = string.Empty;
            if(e.InnerException!=null)
            {
                message += "\n" + GetInnerException(e.InnerException);

            }
            else
            {
                message = e.Message;
            }
            return message;
        }

        public JsonResult GetCategories()
        {
            var viewModel = magazineMediator.GetCategoryViewModel();
            return Json(viewModel);
        }

        [HttpPost]
        public ActionResult GetFoodItemsByCategory(int categoryId)
        {
            var viewModel = magazineMediator.GetFoodItemsByCategory(categoryId);
            return PartialView("_FoodByCategory", viewModel);
         
        }

        [HttpPost]
        public JsonResult GetSubCategories(int id)
        {
            var viewModel = magazineMediator.GetSubCategories(id);
            return new JsonResult { Data = viewModel };
        }
    }
}