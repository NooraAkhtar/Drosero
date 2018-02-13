using Drosero.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Services
{
    public class ApplicationRepository<T> : IApplicationRepository<T> 
    {
        IDataProvider dataProvider;

        public ApplicationRepository(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T item)
        {
            var dbCommand = new SqlCommand("spApplicationHitSave");
            dbCommand.Parameters.Add(new SqlParameter {SqlDbType = System.Data.SqlDbType.Int, ParameterName = "Result", Direction = System.Data.ParameterDirection.Output });
            var result = dataProvider.Save(dbCommand);
            return (T)result.Parameters["Result"].Value;
        }
    }
}
