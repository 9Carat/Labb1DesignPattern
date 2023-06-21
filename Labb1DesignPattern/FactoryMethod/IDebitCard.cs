using Labb1DesignPattern.ObserverDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern
{
    internal interface IDebitCard
    {
        // Card operations
        string GetName();
        double GetBalance();
        // Observer operations
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver(double amount);
    }
}
