using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ServicesInterface
{
    public interface INotificationService
    {
        public void SendMailNotification(string recepient,string body);
    }
}
