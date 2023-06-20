using Labb1DesignPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.Strategy
{
    internal class SwedbankCardStrategy : ICardStrategy
    {
        public IDebitCard card;
        public IDebitCard CreateCard()
        {
            IDebitCard debitCard = new SwedbankCardFactory().OrderNewDebitCard();
            card = debitCard;
            return debitCard;
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine($"You withdrew {amount} SEK from your Swedbank card");
            card.NotifyObserver(amount);
        }
    }
}
