using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Repositories
{
    public class TriviaRepository<T> : ITriviaRepository<T> where T : Trivia, new()
    {
        IDataProvider dataProvider;

        public TriviaRepository(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            var dbCommand = new SqlCommand("spTriviaGetAll");
            var dataTable = dataProvider.GetById(dbCommand);
            var trivias = new List<T>();
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var item = new T();
                    item.Id = Convert.ToInt32(dataRow["ID"]);
                    item.Name = Convert.ToString(dataRow["Name"]).Trim();
                    item.Description = Convert.ToString(dataRow["Description"]);
                    item.FoodItemId = Convert.ToInt32(dataRow["FoodItemId"]);
                    item.ItemId = Convert.ToInt32(dataRow["ItemId"]);
                    item.ImageUrl = Convert.ToString(dataRow["ImageURL"]);
                    trivias.Add(item);
                }
            }
            return trivias;
        }

        public T GetByFoodItemId(int foodItemId)
        {
            var dbCommand = new SqlCommand("spTriviaGetByFoodItemId");
            dbCommand.Parameters.AddWithValue("foodItemId", foodItemId);
            var dataTable = dataProvider.GetById(dbCommand);

            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var item = new T();
                    item.Id = Convert.ToInt32(dataRow["ID"]);
                    item.Name = Convert.ToString(dataRow["Name"]).Trim();
                    item.Description = Convert.ToString(dataRow["Description"]);
                    item.FoodItemId = dataRow["FoodItemId"] != DBNull.Value? Convert.ToInt32(dataRow["FoodItemId"]):0;
                    item.ItemId = dataRow["ItemId"] !=DBNull.Value? Convert.ToInt32(dataRow["ItemId"]):0;
                    item.ImageUrl = Convert.ToString(dataRow["ImageURL"]);
                    return item;
                }
            }
            return null;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetByItemId(int itemId)
        {
            var dbCommand = new SqlCommand("spTriviaGetBytemId");
            dbCommand.Parameters.AddWithValue("itemId", itemId);
            var dataTable = dataProvider.GetById(dbCommand);

            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var item = new T();
                    item.Id = Convert.ToInt32(dataRow["ID"]);
                    item.Name = Convert.ToString(dataRow["Name"]).Trim();
                    item.Description = Convert.ToString(dataRow["Description"]);
                    item.FoodItemId = Convert.ToInt32(dataRow["FoodItemId"]);
                    item.ItemId = Convert.ToInt32(dataRow["ItemId"]);
                    item.ImageUrl = Convert.ToString(dataRow["ImageURL"]);
                    return item;
                }
            }
            return null;
        }

        public T Save(T item)
        {
            throw new NotImplementedException();
        }
    }
}
