using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Services
{
    public class TriviaService<T> : ITriviaService<T>
        where T : Trivia, new()
    {
        ITriviaRepository<T> triviaRepository;

        public TriviaService(ITriviaRepository<T> triviaRepository)
        {
            this.triviaRepository = triviaRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            return triviaRepository.GetAll();
        }

        public T GetByFoodItemId(int foodItemId)
        {
            return triviaRepository.GetByFoodItemId(foodItemId);
        }

        public T GetByItemId(int itemId)
        {
            return triviaRepository.GetByFoodItemId(itemId);
        }

        public T GetById(int id)
        {
            return triviaRepository.GetByFoodItemId(id);
        }                

        public T Save(T item)
        {
            throw new NotImplementedException();
        }
    }
}
