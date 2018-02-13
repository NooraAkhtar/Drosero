using Drosero.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.Domain.Services
{
    public class ApplicationService<T> : IApplicationService<T> 
    {
        private IApplicationRepository<T> applicationRepository;

        public ApplicationService(IApplicationRepository<T> applicationRepository)
        {
            this.applicationRepository = applicationRepository;
        }

        public ApplicationService()
        {

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
            return applicationRepository.Save(item);
        }
    }
}
