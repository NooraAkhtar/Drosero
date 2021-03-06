﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Interfaces
{
    public interface IFoodItemService<T> : IBaseRepository<T>
    {
        IList<T> GetFoodItemsByCategory(int categoryId);
    }
}
