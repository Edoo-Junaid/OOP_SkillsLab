using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DALInterface
{
    public interface IUserDAL
    {
        public bool Register(UserRegistration userRegistration);
        public bool Delete(string userId);

        public bool Save(User user);
    }
}
