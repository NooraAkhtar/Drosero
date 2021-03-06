﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string Phone { get; set; }

        public IList<Address> Addresses { get; set; }
        public string EmailId { get; set; }
    }
}
