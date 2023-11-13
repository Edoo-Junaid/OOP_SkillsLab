using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ServicesInterface
{
    public interface IApplicationService { 

        public Application Get(string applicationId);
        public IEnumerable<Application> GetAll();
        public IEnumerable<Application> GetAllByManagerId(string managerId);

        public void Add(Application application);

        public void Save(Application application);

        public void Delete(string applicationId);

    }
}
