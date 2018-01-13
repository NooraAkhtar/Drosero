using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Interfaces
{
    public interface ITriviaService<T> : IBaseService<T>
    {
        T GetByFoodItemId(int foodItemId);
        T GetByItemId(int itemId);
    }
}
