
using System.Globalization;

namespace TrabalahndoComHeranca.Entities
{
    class BusinessAccount : Account
    {
        public BusinessAccount(string holder, int number, double balance, double loanLimit) : base(holder, number, balance)
        {
            LoanLimit = loanLimit;
        }

        public BusinessAccount()
        {
        }

        public double LoanLimit { get; set; } = 500.0;



        public double Loan(double amount)
        {
           
            if (amount > LoanLimit)
            {
               return  Balance -= LoanLimit + ((5.0 / 100) * amount);
            }
            else
            {
               return  Balance -= amount;
            }
           
        }
        public override string ToString()
        {
            return base.ToString() + "\n Loan Limit $ " + LoanLimit.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
