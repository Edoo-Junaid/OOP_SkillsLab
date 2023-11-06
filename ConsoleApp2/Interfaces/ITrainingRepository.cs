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
        List<Training> getAllTrainings();

        void addTraining(Training training);
        void removeTraining(string training_id);

    }
}
