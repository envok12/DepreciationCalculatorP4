using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationCalculatorP4
{
    class DepreciationStraightLine
    {
        private string dateAddedToInventory;
        private string dateRemovedFromInventory;
        private decimal endValue;
        private int lifetime;
        private decimal startValue;
        private string title;

        public DepreciationStraightLine()
        {

        }

        public string Title
        {
            get;
            set;
        }
        public string DateAddedToInventory
        {
            get { return dateAddedToInventory; }
            set 
            { 
                dateAddedToInventory = value;
                Calc(); 
            }
        }

        public string DateRemovedFromInventory
        {
            get { return dateRemovedFromInventory; }
            set
            {
                dateRemovedFromInventory = value;
                Calc();
            }
        }

        public decimal EndValue
        {
            get { return endValue; }
            set
            {
                endValue = value;
                Calc();
            }
        }

        public int Lifetime
        {
            get { return lifetime; }
            set
            {
                lifetime = value;
                Calc();
            }
        }

        public decimal StartValue
        {
            get { return startValue; }
            set
            {
                startValue = value;
                Calc();
            }
        }

        public virtual void Calc()
        {            

            double depreciationAssetCost = 0.0;
            double initialCost = 0.0;
            double estimatedSalvageValue = 0.0;
            double estimatedUsefulLifeRate = 0.2;
            double annualDepreciation = 0.0;

            depreciationAssetCost = initialCost - estimatedSalvageValue;

            annualDepreciation = estimatedUsefulLifeRate * depreciationAssetCost;

            endValue = (dateAddedToInventory - dateRemovedFromInventory) * annualDepreciation; //Gotta do dateTime conversions and math/get from user 1st.
        }

        public virtual string ToString()
        {
            return "The total value of the inventory is " + endValue;
        }

    }
}
