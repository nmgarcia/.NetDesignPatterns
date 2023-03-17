namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();

            ICar car1 = factory.GetCar("Ford", "Mustang", 2022, 35000);
            car1.ShowDetails("Red");

            ICar car2 = factory.GetCar("Ford", "Mustang", 2022, 35000);
            car2.ShowDetails("Blue");

            ICar car3 = factory.GetCar("BMW", "X5", 2021, 55000);
            car3.ShowDetails("Black");

            ICar car4 = factory.GetCar("BMW", "X5", 2021, 55000);
            car4.ShowDetails("White");
        }
    }
}