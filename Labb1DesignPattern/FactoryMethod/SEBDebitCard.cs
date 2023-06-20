using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern
{
    internal class SEBDebitCard : IDebitCard
    {
        public double GetBalance()
        {
            return 72800;
        }

        public string GetName()
        {
            return "SEB";
        }
    }
}
