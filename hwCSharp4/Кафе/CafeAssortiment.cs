using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Кафе
{
    public class CafeAssortment
    {
        private string _dishName;
        private double _price;
        private string _category;
        private double _weight;

        public CafeAssortment(string dishName, double price, string category, double weight)
        {
            _dishName = dishName;
            _price = price;
            _category = category;
            _weight = weight;
        }

        public virtual string GetDishPrice()
        {
            double res = _price / _weight;
            return $"Стоимость 1г блюда = {res}";
        }

        public virtual string CostOfDrink(int percent)
        {
            double res;
            res = _price - (_price * percent / 100);
            return $"Стоимость напитка со скидкой {percent} = {res}";
        }

        public virtual string Information() => $"Название блюда: {_dishName} Цена: {_price} Категория: {_category}";
    }
}
}
