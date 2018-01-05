using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Repositories
{
    public class ReservationRepository<T> : IReservationRepository<T> where T : Customer, new()
    {
        IDataProvider dataProvider;

        public ReservationRepository(IDataProvider dataProvider)
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
            var dbCommand = new SqlCommand("spReservationDateSave");
            dbCommand.Parameters.Add(new SqlParameter {ParameterName= "ReservationDate", Value=item.ReservationDate});
            dbCommand.Parameters.Add(new SqlParameter { ParameterName = "Count", Value = item.Count });
            dbCommand.Parameters.Add(new SqlParameter { ParameterName = "CustomerName", Value = item.Name });
            dbCommand.Parameters.Add(new SqlParameter { ParameterName = "Mobile", Value = item.Mobile });
            dbCommand.Parameters.Add(new SqlParameter { ParameterName = "Pending", Value = true });
            dbCommand.Parameters.Add(new SqlParameter { ParameterName = "Id", Direction = System.Data.ParameterDirection.InputOutput, Value = item.Id });
            dbCommand = dataProvider.Save(dbCommand);
            item.Id = (int)dbCommand.Parameters["Id"].Value;
            
            return item;
        }
    }
}
