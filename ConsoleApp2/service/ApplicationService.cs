using ConsoleApp2.DALInterface;
using ConsoleApp2.Entitities;
using ConsoleApp2.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    internal class ApplicationService : IApplicationService
    {
        private IApplicationDAL applicationDal;

        private ApplicationService(IApplicationDAL applicationDal)
        {
            this.applicationDal = applicationDal;
        }

        public void Add(Application application)
        {
            throw new NotImplementedException();
        }

        public void Delete(string applicationId)
        {
            throw new NotImplementedException();
        }

        public Application Get(string applicationId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Application> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Application> GetAllByManagerId(string managerId)
        {
            throw new NotImplementedException();
        }

        public void Save(Application application)
        {
            throw new NotImplementedException();
        }
    }
}
