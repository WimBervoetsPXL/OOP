using OOP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public abstract class BankAccount : IAddress, IAccountType
    {
        public abstract string AccountType {  get; }

        public string IBAN { get; set; }
        public decimal Saldo { get; set; }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public void Deposit(decimal amount)
        {
            this.Saldo += amount;
        }

        public virtual void Withdrawal(decimal amount)
        {
            this.Saldo -= amount;
        }


        public abstract decimal CalculateInterest();
    }
}
