using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Interfaces
{
    public interface ITriviaRepository<T> : IBaseRepository<T>
    {
        T GetByFoodItemId(int foodItemId);
        T GetByItemId(int itemId);
    }
}
