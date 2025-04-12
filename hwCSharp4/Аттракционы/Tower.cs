using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Аттракционы
{
    public class Tower : Attractions
    {
        private double _price;

        public Tower(double price, string name, double duration, int maxSeats)
    : base(name, duration, maxSeats, price)
        {
            _price = price;
        }


        public override double GetRevenue(int people = 0)
        {
            return base.GetRevenue();
        }


        public override string Information()
        {
            return base.Information();
        }
    }
}
