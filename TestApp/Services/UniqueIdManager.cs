using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainFinder.Services
{
    public static class UniqueIdManager
    {
        private static int _trainId = 0;
        private static int _passengerId = 0;

        private static int getPassengerId()
        {
            _passengerId++;
            return _passengerId;
        }
        private static int getTrainId()
        {
            _trainId++;
            return _trainId;
        }
    }
}
