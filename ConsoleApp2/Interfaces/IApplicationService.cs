using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface IApplicationService
    {
        public List<Application> GetAllApplications();
        public List<Application> GetApplicationsByManagerId(string managerId);

        public void AddApplication(Application application);


    }
}
