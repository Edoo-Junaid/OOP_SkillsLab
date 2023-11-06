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
        public List<Application> getAllApplications();
        public List<Application> getApplicationsByManagerId(string managerId);

        public void addApplication(Application application);


    }
}
