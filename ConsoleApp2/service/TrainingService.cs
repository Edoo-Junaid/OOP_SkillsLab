using ConsoleApp2.Entitities;
using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    internal class TrainingService : ITrainingService

    {
        private ITrainingRepository trainingRepository;

        public TrainingService(ITrainingRepository trainingRepository) {
            
            this.trainingRepository = trainingRepository;
        }


        public void addTraining(Training training)
        {
            throw new NotImplementedException();
        }

        public void deleteTraining(string trainingID)
        {
            throw new NotImplementedException();
        }

        public List<Training> getAllTrainings()
        {
            throw new NotImplementedException();
        }

        public void getAllTrainingsByDept(string deptID)
        {
            throw new NotImplementedException();
        }

        public void updateTraining()
        {
            throw new NotImplementedException();
        }

    }
}
