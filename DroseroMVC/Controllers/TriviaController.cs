using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using DroseroMVC.Mediators;
using DroseroMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DroseroMVC.Controllers
{
    public class TriviaController : Controller
    {
        private TriviaMediator triviaMediator;

        public TriviaController(ITriviaService<Trivia> triviaService)
        {
            triviaMediator = new TriviaMediator(triviaService);
        }


        // GET: Trivia
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTriviaByItemId(int itemId)
        {
            var trivia = triviaMediator.GetByItemId(itemId);
            return View(trivia);
        }

        public ActionResult GetTriviaByFoodItemId(int foodItemId)
        {
            var trivia = triviaMediator.GetByFoodItemId(foodItemId);
            var viewModel = new TriviaViewModel
            {
                Trivias = new List<Trivia> { trivia }
            };
            return View("Index", viewModel);
        }
    }
}