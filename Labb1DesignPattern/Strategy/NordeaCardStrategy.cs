using Labb1DesignPattern.FactoryMethod;
using Labb1DesignPattern.ObserverDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.Strategy
{
    internal class NordeaCardStrategy : ICardStrategy
    {
        public IDebitCard card;
        public IDebitCard CreateCard()
        {
            IDebitCard debitCard = new NordeaCardFactory().OrderNewDebitCard();
            card = debitCard;
            return debitCard;
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine($"You withdrew {amount} SEK from your Nordea card");
            card.NotifyObserver(amount);
        }
    }
}
