using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.Strategy
{
    internal interface ICardStrategy
    {
        void Withdraw(double amount);
        IDebitCard CreateCard();
    }
}
