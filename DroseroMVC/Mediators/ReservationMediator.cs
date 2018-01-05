using Drosero.Domain.Models;
using Drosero.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroseroMVC.Mediators
{
    public class ReservationMediator
    {
        IReservationService<Customer> service;

        public ReservationMediator(IReservationService<Customer> service)
        {
            this.service = service;
        }

        public Customer Save(Customer customer)
        {
            return service.Save(customer);
        }

    }
}