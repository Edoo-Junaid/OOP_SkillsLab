using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DALInterface
{
    public interface ITrainingDAL
    {
        public Training Get();
        public IEnumerable<Training> GetAll();
        public IEnumerable<Training> GetAllByDept(string dept_id);
        public bool Add(Training training);
        public bool Delete(string training_id);
        public bool Save(Training training);
    }
}
