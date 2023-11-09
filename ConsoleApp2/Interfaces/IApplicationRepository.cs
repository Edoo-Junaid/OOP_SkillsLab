using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface IApplicationRepository
    {
        List<Application> GetAllApplications();
        List<Application> GetApplicationsByManagerId(string managerId);

        void AddApplication(Application application);
    }
}
