using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Drosero.Domain.Models;

namespace DroseroMVC.ViewModels
{
    public class FoodItemViewModel
    {
        public IList<FoodItem> FoodItems { get; set; }
    }
}