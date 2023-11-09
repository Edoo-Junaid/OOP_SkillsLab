using ConsoleApp2.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface ITrainingRepository
    {
        List<Training> GetAllTrainings();

        void AddTraining(Training training);
        void RemoveTraining(string training_id);

        void UpdateTraining(Training training);

        List<Training> GetAllTrainingByDept(string dept_id);

    }
}
