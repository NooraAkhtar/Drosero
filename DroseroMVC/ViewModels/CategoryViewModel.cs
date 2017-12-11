using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Drosero.Domain.Models;

namespace DroseroMVC.ViewModels
{
    public class CategoryViewModel
    {
        public IList<Category> Categories { get; set; }
    }
}