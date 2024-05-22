using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDLL
{
    public class ProductionCalculator
    {
        private readonly double _cerealCoefficient = 130.0 / 6.0;
        private readonly double _oilCoefficient = 60.0 / 6.0;
        private readonly double _sugarCoefficient = 60.0 / 6.0;
        private readonly double _powderCoefficient = 3.5 * 5.0 / 6.0;
        private readonly double _waterCoefficient = 180.0 / 6.0;

        public int CalculatePossibleProduction(double amountCereal, double amountOil, double amountSugar, double amountPowder, double amountWater)
        {
            double minIngredientAmount = double.MaxValue;

            if (amountCereal / _cerealCoefficient < minIngredientAmount)
            {
                minIngredientAmount = amountCereal / _cerealCoefficient;
            }

            if (amountOil / _oilCoefficient < minIngredientAmount)
            {
                minIngredientAmount = amountOil / _oilCoefficient;
            }

            if (amountSugar / _sugarCoefficient < minIngredientAmount)
            {
                minIngredientAmount = amountSugar / _sugarCoefficient;
            }

            if (amountPowder / _powderCoefficient < minIngredientAmount)
            {
                minIngredientAmount = amountPowder / _powderCoefficient;
            }

            if (amountWater / _waterCoefficient < minIngredientAmount)
            {
                minIngredientAmount = amountWater / _waterCoefficient;
            }

            return (int)Math.Floor(minIngredientAmount);
        }
    }
}
