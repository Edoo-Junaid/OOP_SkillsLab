using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Entitities;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Repository
{
    internal class ApplicationRepository : IApplicationRepository
    {
        public List<Application> getAllApplications()
        {
            throw new NotImplementedException();
        }

        public List<Application> GetApplications()
        {
            throw new NotImplementedException();
        }

        public List<Application> getApplicationsByManagerId(string managerId)
        {
            throw new NotImplementedException();
        }
    }
}
