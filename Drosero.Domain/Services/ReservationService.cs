using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Services
{
    public class ReservationService<T> : IReservationService<T> where T : Customer, new()
    {
        private IReservationRepository<T> reservationRepository;

        public ReservationService(IReservationRepository<T> reservationRepository)
        {
            this.reservationRepository = reservationRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T item)
        {
            return reservationRepository.Save(item);
        }
    }
}
