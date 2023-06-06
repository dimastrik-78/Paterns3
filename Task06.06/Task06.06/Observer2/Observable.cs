using System;
using System.Collections.Generic;

namespace Task06._06.Observer2
{
    public class Observable : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        
        private int _x;

        public void RemadeX(int x)
        {
            _x = x;
            NotifyObserver();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var item in _observers)
            {
                Console.WriteLine(item.Notify(_x));
            }
        }
    }
}