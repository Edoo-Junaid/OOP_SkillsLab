using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ServicesInterface
{
    public interface ITrainingService
    {
        public Training Get(string trainingID);
        public IEnumerable<Training> GetAll();
        public IEnumerable<Training> GetAllByDept(string deptID);

        public bool Add(Training training);
        public bool Save(Training training);
        public bool Delete(string trainingID);


    }
}
