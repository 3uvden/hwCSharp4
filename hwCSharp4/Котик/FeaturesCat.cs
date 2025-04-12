using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Котик
{
    public class FeaturesCat
    {
        private string _name;
        private string _breed;
        private double _weight;
        private double _height;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Breed { get; }

        public string CatOwner { get; }

        public FeaturesCat(string name, string breed, double weight, double height, string catOwner)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
            Height = height;
            CatOwner = catOwner;
        }

        public string Info() => $"Кличка: {Name} Рост: {Height} Вес: {Weight} Порода: {Breed} Хозяин: {CatOwner}";
    }
}
