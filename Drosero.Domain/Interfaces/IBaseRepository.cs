using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        IList<T> GetAll();
        T GetById(int id);

        T Save(T item);

        bool Delete(int id);
    }
}
