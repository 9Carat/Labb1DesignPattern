using Labb1DesignPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.Strategy
{
    internal class SEBCardStrategy : ICardStrategy
    {
        public IDebitCard CreateCard()
        {
            IDebitCard debitCard = new SEBCardFactory().OrderNewDebitCard();
            return debitCard;
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine($"You withdrew {amount} sek from your SEB card");
        }
    }
}
