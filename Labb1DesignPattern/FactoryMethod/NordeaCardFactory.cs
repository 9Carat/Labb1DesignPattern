using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.FactoryMethod
{
    internal class NordeaCardFactory : DebitCardFactory
    {
        protected override IDebitCard CreateDebitCard()
        {
            IDebitCard card = new NordeaDebitCard();
            return card;
        }
    }
}
