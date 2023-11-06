using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    internal class UserService
    {

        public void login()
        {
            throw new NotImplementedException();
        }

        public void logout()
        {
            throw new NotImplementedException();
        }   

        public void register()
        {
            throw new NotImplementedException();
        }

        public bool approveRequest(string employeeId, string trainingId)
        {
            //implementation
            return true;
        }

        public void notify()
        {
            Console.WriteLine("Notified");
        }

        public bool declineRequest(string employeeId, string trainingId)
        {
            //implementation
            return true;
        }
    }
}
