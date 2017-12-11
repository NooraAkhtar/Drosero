using System;
using System.Collections.Generic;
using System.Data;
using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System.Data.SqlClient;
using Drosero.Domain.DBHelper;

namespace Drosero.Domain.Repositories
{
    public class CategoryRepository<T> : ICategoryRepository<T> where T : Category, new()
    {
        IDataProvider dataProvider ;

        public CategoryRepository()
        {
            dataProvider = new DataProvider();
        }

        public bool Delete(int id)
        {
            return true;
        }

        public IList<T> GetAll()
        {
            var dbCommand = new SqlCommand("spCategoryGetAll");
            var dataTable = dataProvider.GetById(dbCommand);
            var categories = new List<T>();
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var item = new T();
                    item.Id = Convert.ToInt32(dataRow["Id"]);
                    item.Name = Convert.ToString(dataRow["categoryName"]);
                    categories.Add(item);
                }
            }
            return categories;
        }

        public T GetById(int id)
        {
            var item = new T();
            item.Id = 1;
            item.Name = "Desserts";

            return item;
        }

        public T Save(T item)
        {
            //var item = new T();
            //item.Id = 1;
            //item.Name = "Desserts";

            return item;
        }
    }
}