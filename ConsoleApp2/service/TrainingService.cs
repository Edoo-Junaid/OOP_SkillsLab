using ConsoleApp2.DALInterface;
using ConsoleApp2.Entitities;
using ConsoleApp2.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    internal class TrainingService : ITrainingService

    {
        private ITrainingDAL trainingDal;

        public TrainingService(ITrainingDAL trainingDal) {
            
            this.trainingDal = trainingDal;
        }

        public bool Add(Training training)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string trainingID)
        {
            throw new NotImplementedException();
        }

        public Training Get(string trainingID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAllByDept(string deptID)
        {
            throw new NotImplementedException();
        }

        public bool Save(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
