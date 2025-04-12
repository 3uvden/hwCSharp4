using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Кафе
{
    public class Drink : CafeAssortment
    {
        private double _volume;

        public Drink(double volume, string dishName, double price, string category, double weight)
           : base(dishName, price, category, weight)
        {
            _volume = volume;
        }

        public override string Information()
        {
            return base.Information();
        }

        public override string CostOfDrink(int percent)
        {
            return base.CostOfDrink(15);
        }
    }
}
