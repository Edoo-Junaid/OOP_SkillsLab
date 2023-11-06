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
        public void addTraining(Training training)
        {
            throw new NotImplementedException();
        }

        public List<Training> getAllTrainings()
        {
            throw new NotImplementedException();
        }

        public List<Training> getTrainingByManager(string status)
        {
            throw new NotImplementedException();
        }

        public void removeTraining(string training_id)
        {
            throw new NotImplementedException();
        }
    }
}
