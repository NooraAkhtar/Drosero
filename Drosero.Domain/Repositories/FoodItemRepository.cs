using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drosero.Domain.DBHelper;

namespace Drosero.Domain.Repositories
{
    public class FoodItemRepository<T> : IFoodItemRepository<T>
        where T : FoodItem, new()
    {
        public IDataProvider dataProvider { get; set; }

        public FoodItemRepository()
        {
            dataProvider = new DataProvider();
        }

        public bool Delete(int id)
        {
            var dbCommand = new SqlCommand();
            dbCommand.Parameters.AddWithValue("id", id);
            return dataProvider.Delete(dbCommand)>0;
        }

        public IList<T> GetAll()
        {
            var dbCommand = new SqlCommand("spFoodItemsByCategoryGetAll");
            var dataTable = dataProvider.GetAll(dbCommand);
            var foodItems = new List<T>();
            if(dataTable!=null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var item = new T();
                    item.Id = Convert.ToInt32(dataRow["id"]);
                    item.Name = Convert.ToString(dataRow["foodName"]);
                    item.Description = Convert.ToString(dataRow["description"]);
                    item.CategoryId= Convert.ToInt32(dataRow["dategoryId"]);
                    item.Price= Convert.ToDecimal(dataRow["price"]);
                    foodItems.Add(item);
                }
            }

            return foodItems;
        }

        public T GetById(int id)
        {
            var dbCommand = new SqlCommand("spFoodItemsByCategoryGetAll");
            dbCommand.Parameters.AddWithValue("categoryId", id);
            var dataTable = dataProvider.GetById(dbCommand);
           
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var item = new T();
                    item.Id = Convert.ToInt32(dataRow["Id"]);
                    item.Name = Convert.ToString(dataRow["Name"]);
                    item.Description = Convert.ToString(dataRow["Description"]);
                    item.CategoryId = Convert.ToInt32(dataRow["CategoryId"]);
                    item.Price = Convert.ToDecimal(dataRow["Price"]);
                    return item;
                }
            }
            return null;
        }

        public T Save(T item)
        {
            var dbCommand = new SqlCommand("spCategorySave");
            dbCommand.Parameters.AddWithValue("id", item.Id);
            dbCommand.Parameters.AddWithValue("name", item.Name);
            dbCommand.Parameters.AddWithValue("description", item.Description);
            dbCommand.Parameters.AddWithValue("categoryId", item.CategoryId);
            dbCommand.Parameters.AddWithValue("price", item.Price);

            item.Id = dataProvider.Save(dbCommand);

            return item;
        }

        public IList<T> GetFoodItemsByCategory(int categoryId)
        {
            var dbCommand = new SqlCommand("spFoodItemsByCategoryGetAll");
            dbCommand.Parameters.AddWithValue("categoryId", categoryId);
            var dataTable = dataProvider.GetById(dbCommand);
            var foodItems = new List<T>();
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var item = new T();
                    item.Id = Convert.ToInt32(dataRow["Id"]);
                    item.Name = Convert.ToString(dataRow["foodName"]);
                    item.Description = Convert.ToString(dataRow["Description"]);
                    item.CategoryId = Convert.ToInt32(dataRow["CategoryId"]);
                    item.Price = Convert.ToDecimal(dataRow["Price"]);
                    foodItems.Add(item);
                }
            }
            return foodItems;
        }

    }
}
