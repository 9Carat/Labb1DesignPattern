using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb1DesignPattern.FactoryMethod;

namespace Labb1DesignPattern
{
    internal class SwedbankCardFactory : DebitCardFactory
    {
        protected override IDebitCard CreateDebitCard()
        {
            IDebitCard card = new SwedbankDebitCard();
            return card;
        }
    }
}
