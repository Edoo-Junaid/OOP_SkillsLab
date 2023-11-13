using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DALInterface
{
    public interface IApplicationDAL
    {
        public Application Get(string applicationId);
        public IEnumerable<Application> GetAll();
        public IEnumerable<Application> GetAllByManagerId(string managerId);
        public bool Add(Application application);
        public bool Save(Application application);
        public bool Delete(string applicationId);
    }
}
