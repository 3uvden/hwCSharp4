using hwCSharp4.Аттракционы;
using hwCSharp4.Животные;
using hwCSharp4.Кафе;
using hwCSharp4.Студент;

namespace hwCSharp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeaturesStudent student = new FeaturesStudent("Оклик Даниил Павлович", 89, 2145);
            Console.WriteLine(student.Info());

            Cat cat = new Cat("Кот", "Сиамский", "22.03.2018", 3);
            Console.WriteLine(cat.Information() + "\n");
;

            Tower tower = new Tower(250, "Башни близнецы", 14.3, 15);
            Console.WriteLine(tower.GetRevenue(10));
            Console.WriteLine(tower.Information() + "\n");


            Dish dish = new Dish(900, 200, "Салат Цезарь", 1150, "Салат");
            Console.WriteLine(dish.Information());
            Console.WriteLine(dish.GetDishPrice() + "\n");

            Drink drink = new Drink(200, "Пина колада", 1400, "Для богатых", 250);
            Console.WriteLine(drink.Information());
            Console.WriteLine(drink.CostOfDrink(15) + "\n");
        }
    }
}
