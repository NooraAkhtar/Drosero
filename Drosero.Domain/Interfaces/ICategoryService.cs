﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Interfaces
{
    public interface ICategoryService<T> : IBaseRepository<T>
    {
        IList<T> GetSubCategories(int id);

    }
}
