using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Кафе
{
    public class Dish : CafeAssortment
    {
        private double _calories;
        private double _weight;

        public Dish(double calories, double weight, string dishName, double price, string category)
            : base(dishName, price, category, weight)
        {
            _calories = calories;
            _weight = weight;
        }

        public override string GetDishPrice()
        {
            return base.GetDishPrice();
        }

        public override string Information()
        {
            return base.Information();
        }
    }
}
