using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern
{
    internal class SwedbankDebitCard : IDebitCard
    {
        public double GetBalance()
        {
            return 5500;
        }

        public string GetName()
        {
            return "Swedbank";
        }
    }
}
