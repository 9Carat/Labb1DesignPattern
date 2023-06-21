﻿using Labb1DesignPattern.ObserverDesignPattern;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern
{
    internal class SEBDebitCard : IDebitCard
    {
        private List<IObserver> observers = new List<IObserver>();
        public double GetBalance()
        {
            return 72800;
        }

        public string GetName()
        {
            return "SEB";
        }

        public void NotifyObserver(double amount)
        {
            foreach (IObserver observer in observers)
            {
                observer.Observe(amount);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Debug.WriteLine($"Observer {((Observer)observer).ObserverName} has been added");
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Debug.WriteLine($"Observer {((Observer)observer).ObserverName} has been removed");
            observers.Remove(observer);
        }
    }
}
