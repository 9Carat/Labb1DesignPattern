using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.FactoryMethod
{
    internal abstract class DebitCardFactory
    {
        protected abstract IDebitCard CreateDebitCard();
        public IDebitCard OrderNewDebitCard()
        {
            IDebitCard debitCard = CreateDebitCard();
            return debitCard;
        }
    }
}
