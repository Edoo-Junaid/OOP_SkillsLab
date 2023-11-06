using ConsoleApp2.Entitities;
using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    internal class ApplicationService: IApplicationService
    {
        private IApplicationRepository applicationRepository;

        private ApplicationService(IApplicationRepository applicationRepository)
        {
            this.applicationRepository = applicationRepository;
        }

        public void addApplication(Application application)
        {
            throw new NotImplementedException();
        }

        public List<Application> getAllApplications()
        {
            return applicationRepository.getAllApplications();
        }

        public List<Application> getApplicationsByManagerId(string managerId)
        {
            return applicationRepository.getApplicationsByManagerId(managerId);
        }
    }
}
