using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Животные
{
    public class Cat : Animals
    {
        public Cat(string name, string breed, string birthDate, double weight) 
            :base(name, breed, birthDate, weight) { }

        public bool CatchMouse(int num)
        {
            if (num <= 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string Information() => base.Information();
    }
}
