using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.ObserverDesignPattern
{
    internal class Observer : IObserver
    {
        public string ObserverName { get; set; }
        public Observer(string name)
        {
            ObserverName = name;
        }
        public void Attach(IDebitCard card) 
        {
            card.RegisterObserver(this);
        }
        public void Detach(IDebitCard card)
        {
            card.RemoveObserver(this);
        }
        public void Observe(double amount)
        {
            Debug.WriteLine($"Hello {ObserverName}. {amount} SEK has been withdrawed from your account");
        }
    }
}
