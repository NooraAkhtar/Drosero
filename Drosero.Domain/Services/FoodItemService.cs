using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Services
{
    public class FoodItemService<T> : IFoodItemService<T> where T : FoodItem, new()
    {
        private IFoodItemRepository<T> foodItemRepository;

        public FoodItemService(IFoodItemRepository<T> foodItemRepository)
        {
            this.foodItemRepository = foodItemRepository;
        }
        public bool Delete(int id)
        {
            return foodItemRepository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return foodItemRepository.GetAll();
        }

        public T GetById(int id)
        {
            return foodItemRepository.GetById(id);
        }

        public T Save(T item)
        {
            return foodItemRepository.Save(item);
        }

        public IList<T> GetFoodItemsByCategory(int categoryId)
        {
            return foodItemRepository.GetFoodItemsByCategory(categoryId);
        }
    }
}
