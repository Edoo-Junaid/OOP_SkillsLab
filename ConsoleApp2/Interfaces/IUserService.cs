using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface IUserService
    {
        public void registerUser();

        public bool approveService();   

        public bool declineRequest();
    }
}
