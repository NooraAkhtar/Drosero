using Drosero.Domain.Interfaces;
using DroseroMVC.Mediators;
using DroseroMVC.ViewModels;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Drosero.Domain.Models;
using Drosero.Domain.Repositories;
using Drosero.Domain.Services;
using Unity.Attributes;

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
            var viewModel = new MagazineViewModel
            {
                CategoryViewModel = magazineMediator.GetCategoryViewModel(),
            };
            return View(viewModel);
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