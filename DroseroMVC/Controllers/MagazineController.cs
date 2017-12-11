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
        public MagazineController()
        {
            magazineMediator = new MagazineMediator(new CategoryService<Category>(new CategoryRepository<Category>()), 
                new FoodItemService<FoodItem>(new FoodItemRepository<FoodItem>()));
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
            return new JsonResult {Data = viewModel};
        }

        [HttpPost]
        public ActionResult GetFoodItemsByCategory(int categoryId)
        {
            var viewModel = magazineMediator.GetFoodItemsByCategory(categoryId);
            return PartialView("_FoodByCategory", viewModel);
            //return new JsonResult {Data = viewModel};
        }
    }
}