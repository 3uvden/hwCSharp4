using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Котик
{
    public class MethodCat
    {
        private string _name;
        private string _catOwner;
        private string _breed;
        private double _weight;
        private double _height;

        public void SetName(string name) => _name = name;
        public string GetName() => _name;

        public void SetHeight(double height) => height = _height;
        public double GetHeight() => _height;

        public void SetWeight(double weight) => weight = _weight;
        public double GetWeight() => _weight;

        public string GetBreed() => _breed;

        public string GetCatOwner() => _catOwner;

        public MethodCat(string name, string breed, double weight, double height, string catOwner)
        {
            _name = name;
            _breed = breed;
            _weight = weight;
            _height = height;
            _catOwner = catOwner;
        }

        public string Info() => $"Кличка: {_name} Рост: {_height} Вес: {_weight} Порода: {_breed} Хозяин: {_catOwner}";
    }
}
