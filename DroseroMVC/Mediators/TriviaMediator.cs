using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroseroMVC.Mediators
{
    public class TriviaMediator
    {
        ITriviaService<Trivia> triviaService;

        public TriviaMediator(ITriviaService<Trivia> triviaService)
        {
            this.triviaService = triviaService;
        }

        public IList<Trivia> GetAll()
        {
            return triviaService.GetAll();
        }

        public Trivia GetByFoodItemId(int foodItemId)
        {
            return triviaService.GetByFoodItemId(foodItemId);
        }

        public Trivia GetByItemId(int itemId)
        {
            return triviaService.GetByFoodItemId(itemId);
        }
    }
}