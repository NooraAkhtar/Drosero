using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drosero.Domain.Interfaces;

namespace Drosero.Domain.DBHelper
{
    public class DataProvider:IDataProvider
    {
        private string connectionString;

        public DataProvider(string connectionString)
        {
            this.connectionString = connectionString;
            //this.connectionString =  @"Data Source=indbanl175\droserodatabase;Initial Catalog=droseroDB;Persist Security Info=True;User ID=sa;Password=paSSw0rd";
        }

        public DataTable GetAll(SqlCommand sqlCommand)
        {
            var dataSet = new DataSet();
            using (var connection = new SqlConnection(connectionString))
            {
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataSet);
            }
            return dataSet.Tables[0];
        }

        public DataTable GetById(SqlCommand sqlCommand)
        {
            var dataSet = new DataSet();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    var sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    sqlDataAdapter.Fill(dataSet);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
           
            return dataSet.Tables[0];
        }

        public SqlCommand Save(SqlCommand sqlCommand)
        {
            return DBExecuteNonQuery(sqlCommand);
        }

        public int Delete(SqlCommand sqlCommand)
        {
           return DBExecuteNonQueryDelete(sqlCommand);
        }

        private SqlCommand DBExecuteNonQuery(SqlCommand sqlCommand)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery(); 
            }
            return sqlCommand;
        }

        private int DBExecuteNonQueryDelete(SqlCommand sqlCommand)
        {
            var result = 0;
            using (var connection = new SqlConnection(connectionString))
            {
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection.Open();
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
    }
}
