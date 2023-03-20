/*
 In this example, the Car class represents the intrinsic state, which is the car's brand, model, year, and price, while the color parameter passed
to the ShowDetails method represents the extrinsic state, which is the car's color.
The CarFactory class is responsible for creating and managing the flyweight objects, and the Program class is the client that uses the flyweight objects.

When the client requests a car from the factory, the factory checks if the car with the specified brand, model, and year already exists in the dictionary.
If it does, the factory returns the existing car object. If it doesn't, the factory creates a new car object and adds it to the dictionary.
This ensures that we don't create duplicate objects, which can save memory and improve performance.

In the client code, we create four car objects, two of which have the same brand, model, and year. When we call the ShowDetails method on each car object,
we pass in a different color for each car, which represents the extrinsic state. The output of the program shows that we are able to create multiple car 
objects with the same intrinsic state but different extrinsic states, which demonstrates the flyweight design pattern.
 */

namespace Flyweight
{
    using System;
    using System.Collections.Generic;

    // Flyweight interface
    public interface ICar
    {
        void ShowDetails(string color);
    }

    // Concrete Flyweight class
    public class Car : ICar
    {
        private string brand;
        private string model;
        private int year;
        private double price;

        public Car(string brand, string model, int year, double price)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public void ShowDetails(string color)
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}, Color: {color}, Price: {price}");
        }
    }

    // Flyweight factory
    public class CarFactory
    {
        private Dictionary<string, ICar> cars = new Dictionary<string, ICar>();

        public ICar GetCar(string brand, string model, int year, double price)
        {
            string key = brand + model + year;

            if (cars.ContainsKey(key))
            {
                return cars[key];
            }
            else
            {
                ICar car = new Car(brand, model, year, price);
                cars.Add(key, car);
                return car;
            }
        }
    }
}
