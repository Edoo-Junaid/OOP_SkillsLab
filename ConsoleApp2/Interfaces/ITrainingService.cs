using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface ITrainingService
    {
        public void addTraining();
        public void updateTraining();
        public void deleteTraining(string trainingID);

        public List<Training> getAllTrainings();
        public void getAllTrainingsByDept(string deptID);
    }
}
