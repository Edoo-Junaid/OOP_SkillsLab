using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    public interface ITrainingService
    {
        public void AddTraining(Training training);
        public void UpdateTraining(Training training);
        public void DeleteTraining(string trainingID);

        public List<Training> GetAllTrainings();
        public void GetAllTrainingsByDept(string deptID);
    }
}
