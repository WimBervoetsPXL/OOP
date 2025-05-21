using OOP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Spaarrekening : BankAccount, IAddress, IAccountType
    {
        public override string AccountType => "Spaarrekening";

        public override decimal CalculateInterest()
        {
            return base.Saldo * 0.05m;
        }

        public override void Withdrawal(decimal amount)
        {
            base.Withdrawal(amount);
            base.Saldo -= 1; // 1 euro kosten
        }
    }
}
