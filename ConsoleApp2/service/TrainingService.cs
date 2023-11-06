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
        public void addTraining()
        {
            throw new NotImplementedException();
        }

        public void deleteTraining(string trainingID)
        {
            throw new NotImplementedException();
        }

        public void getAllTrainings()
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
