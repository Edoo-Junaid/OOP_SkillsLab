using ConsoleApp2.Entitities;
using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
    internal class TrainingRepository : ITrainingRepository
    {
        public void AddTraining(Training training)
        {
            throw new NotImplementedException();
        }

        public List<Training> GetAllTrainingByDept(string dept_id)
        {
            throw new NotImplementedException();
        }

        public List<Training> GetAllTrainings()
        {
            throw new NotImplementedException();
        }

        public void RemoveTraining(string training_id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTraining(Training training)
        {
            throw new NotImplementedException();
        }

    }
}
