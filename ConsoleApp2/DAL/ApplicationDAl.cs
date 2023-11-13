using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Entitities;
using ConsoleApp2.DALInterface;

namespace ConsoleApp2.Repository
{
    public class ApplicationDAL : IApplicationDAL
    {

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

        public bool Add(Application application)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string applicationId)
        {
            throw new NotImplementedException();
        }

        public bool Save(Application application)
        {
            throw new NotImplementedException();
        }
    }
}
