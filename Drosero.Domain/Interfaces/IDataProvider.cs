using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Interfaces
{
    public interface IDataProvider
    {
        DataTable GetAll(SqlCommand sqlCommand);

        DataTable GetById(SqlCommand sqlCommand);

        int Save(SqlCommand sqlCommand);

        int Delete(SqlCommand sqlCommand);
    }
}
