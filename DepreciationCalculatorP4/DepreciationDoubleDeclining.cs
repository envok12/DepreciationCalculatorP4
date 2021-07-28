using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationCalculatorP4
{
    class DepreciationDoubleDeclining : DepreciationStraightLine
    {

        public override void Calc()
        {
            double depreciationAssetCost = 0.0;
            double initialCost = 0.0;
            double estimatedSalvageValue = 0.0;
            double estimatedUsefulLifeRate = 0.2;
            double annualDepreciation = 0.0;

            EndValue = (decimal)(2 * estimatedUsefulLifeRate * initialCost);
        }
        public override string ToString()
        {
            return "Double declining output stuff. ";
        }
    }
}
