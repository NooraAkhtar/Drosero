using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Interfaces
{
    public interface IFoodItemService<T> : IBaseService<T>
    {
        IList<T> GetFoodItemsByCategory(int categoryId);
    }
}
