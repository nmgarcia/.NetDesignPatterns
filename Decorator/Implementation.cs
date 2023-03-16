/*
 In this example, we have a Component interface ICar that defines the common interface for all objects that can be decorated.
The CompactCar class is a Concrete Component that provides the basic implementation.

The CarDecorator abstract class is the base class for all decorators. It implements the ICar interface and has a reference to the ICar object being decorated.
It also provides default implementations for GetDescription() and GetCost() that simply call the corresponding methods on the wrapped object.

The LeatherSeatsDecorator and SunroofDecorator classes are Concrete Decorators that add functionality to the cars.
They both extend the CarDecorator class and override the GetDescription() and GetCost() methods to add their own functionality.

The client code creates a CompactCar object and decorates it with a LeatherSeatsDecorator and a SunroofDecorator.
Finally, it prints the description and cost of the car with each decorator applied.
 */


namespace Decorator
{
    // Component interface
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }

    // Concrete component
    public class CompactCar : ICar
    {
        public string GetDescription()
        {
            return "Compact car";
        }

        public double GetCost()
        {
            return 15000.00;
        }
    }

    // Decorator abstract class
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }
    }

    // Concrete decorator 1
    public class LeatherSeatsDecorator : CarDecorator
    {
        public LeatherSeatsDecorator(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", leather seats";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 1200.00;
        }
    }

    // Concrete decorator 2
    public class SunroofDecorator : CarDecorator
    {
        public SunroofDecorator(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", sunroof";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 800.00;
        }
    }


}
