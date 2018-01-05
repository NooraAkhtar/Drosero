using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Services
{
    public class CategoryService<T> : ICategoryService<T>
        where T : Category, new()
    {
        private ICategoryRepository<T> categoryRepository;

        public CategoryService(ICategoryRepository<T> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public bool Delete(int id)
        {
            return categoryRepository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public T GetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        public IList<T> GetSubCategories(int id)
        {
            return categoryRepository.GetSubCategories(id);
        }

        public T Save(T item)
        {
            return categoryRepository.Save(item);
        }
    }
}