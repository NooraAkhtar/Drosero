using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroseroMVC.ViewModels
{
    public class TriviaViewModel
    {
        public IList<Trivia> Trivias { get; set; }
    }
}