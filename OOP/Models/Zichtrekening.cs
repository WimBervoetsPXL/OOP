using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Zichtrekening : BankAccount
    {
        public override string AccountType => "Zichtrekening";

        public override decimal CalculateInterest()
        {
            return base.Saldo * 0.01m;
        }
    }
}
