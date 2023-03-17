/*
 In this example, the StockMarket class is the subject which maintains a list of observers and notifies them when the stock price changes. 
The Investor class is a concrete observer that receives updates from the StockMarket.

The ISubject and IObserver interfaces define the methods that must be implemented by concrete subjects and observers, respectively.

The Main method in the Program class demonstrates how the StockMarket notifies its observers when the stock price changes. 
In this example, two Investor objects are attached to the StockMarket and receive updates when the stock price changes. 
One of the investors is later detached, so only one investor receives updates.
 */
using System;
using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    /// Subject interface
    /// </summary>
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    /// <summary>
    /// Concrete subject
    /// </summary>
    public class StockMarket : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private float _stockPrice;

        public float StockPrice
        {
            get => _stockPrice;
            set
            {
                if (_stockPrice != value)
                {
                    _stockPrice = value;
                    Notify();
                }
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(StockPrice);
            }
        }
    }

    /// <summary>
    /// Observer interface
    /// </summary>
    public interface IObserver
    {
        void Update(float stockPrice);
    }

    /// <summary>
    /// Concrete observer
    /// </summary>
    public class Investor : IObserver
    {
        private readonly string _investorName;
        private float _stockPrice;

        public Investor(string investorName)
        {
            _investorName = investorName;
        }

        public void Update(float stockPrice)
        {
            Console.WriteLine($"{_investorName}: Stock price has changed to {stockPrice}");
            _stockPrice = stockPrice;
        }
    }

}
