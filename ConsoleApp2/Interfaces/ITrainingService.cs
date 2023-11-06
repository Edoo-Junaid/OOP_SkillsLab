using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface ITraining
    {
        public void addTraining();
        public void updateTraining();
        public void deleteTraining(string trainingID);
    }
}
