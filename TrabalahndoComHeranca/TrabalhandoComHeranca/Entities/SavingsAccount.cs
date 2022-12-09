using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalahndoComHeranca.Entities
{
    class SavingsAccount : Account
    {
        public double interestRate { get; set; }

        public SavingsAccount(string holder, int number, double balance, double interestRate) 
            : base(holder, number, balance)
        {
            this.interestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * interestRate;
        }

        public SavingsAccount()
        {
        }
    }
}
