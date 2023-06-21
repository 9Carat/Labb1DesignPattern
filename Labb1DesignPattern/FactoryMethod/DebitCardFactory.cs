using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.FactoryMethod
{
    internal abstract class DebitCardFactory
    {
        // This section implements the Factory method design pattern
        protected abstract IDebitCard CreateDebitCard();
        // Orders a new debit card depending on the choosen strategy
        public IDebitCard OrderNewDebitCard()
        {
            IDebitCard debitCard = CreateDebitCard();
            return debitCard;
        }
    }
}
