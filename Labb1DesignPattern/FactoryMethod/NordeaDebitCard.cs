using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern
{
    internal class NordeaDebitCard : IDebitCard
    {
        public double GetBalance()
        {
            return 7540;
        }

        public string GetName()
        {
            return "Nordea";
        }
    }
}
