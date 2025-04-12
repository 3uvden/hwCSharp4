using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Животные
{
    public class Animals
    {
        private string _name;
        private string _breed;
        private string _birthdayDate;
        private double _weight;

        public Animals(string name, string breed, string birthdayDate, double weight)
        {
            _name = name;
            _breed = breed;
            _birthdayDate = birthdayDate;
            _weight = weight;
        }

        public virtual string Information() => $"Имя: {_name} Порода: {_breed} Вес: {_weight} Дата рождения: {_birthdayDate}";
    }
}
