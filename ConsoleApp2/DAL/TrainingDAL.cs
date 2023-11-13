using ConsoleApp2.DALInterface;
using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
    public class TrainingDAL : ITrainingDAL
    {

        public Training Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAllByDept(string dept_id)
        {
            throw new NotImplementedException();
        }

        public bool Add(Training training)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string training_id)
        {
            throw new NotImplementedException();
        }


        public bool Save(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
