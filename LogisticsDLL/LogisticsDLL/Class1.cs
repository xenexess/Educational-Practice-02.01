using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsDLL
{
        public class LogisticsCalculator
        {
            public double CalculateLogisticsCost(double distance, double costPerKm)
            {
            double CalculateLogisticsCost = distance* costPerKm;
            return CalculateLogisticsCost;
            }
        }
}
