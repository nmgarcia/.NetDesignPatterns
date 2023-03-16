namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new CompactCar();

            Console.WriteLine(car.GetDescription() + " costs $" + car.GetCost());

            car = new LeatherSeatsDecorator(car);

            Console.WriteLine(car.GetDescription() + " costs $" + car.GetCost());

            car = new SunroofDecorator(car);

            Console.WriteLine(car.GetDescription() + " costs $" + car.GetCost());
        }
    }
}