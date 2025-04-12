using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharp4.Кинотеатр
{
    public class FeaturesCinema
    {
        private string _movieName;
        private double _price;
        private int _peopleCapacity;

        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }

        public double Price => _price;

        public string CinemaHall { get; }

        public FeaturesCinema(string movieName, double price, int peopleCapacity, string cinemaHall)
        {
            _movieName = movieName;
            _price = price;
            _peopleCapacity = peopleCapacity;
            CinemaHall = cinemaHall;
        }

        public string Information() => $"Название фильма: {MovieName} Цена билета: {Price} Вместимось: {_peopleCapacity} Кинозал: {CinemaHall}";
    }
}
