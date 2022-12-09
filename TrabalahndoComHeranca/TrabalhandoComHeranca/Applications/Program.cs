
using TrabalahndoComHeranca.Entities;

namespace TrabalahndoComHeranca.Applications
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account c1 = new Account("Sandro", 12345, 520.0);
            BusinessAccount b1 = new BusinessAccount("Engenharia", 12451, 20000.0, 2500.0);
           
            Console.WriteLine(c1);
            Console.WriteLine(b1);

            double loan = 3000.0;
            
            Console.WriteLine("\n Loan amount $ " + loan);
            b1.Loan(loan);
            
            Console.WriteLine(b1);
            
            c1.Deposit(480.0);
            Console.WriteLine(c1);

            // Upcasting
            Account cc1 = b1;
            Console.WriteLine(cc1);

            Account cc2 = new BusinessAccount();
            Account cc3 = new SavingsAccount();


            // Downcasting
            BusinessAccount cc4 = (BusinessAccount) cc2;

            // outra forma de fazer downcast
            BusinessAccount cc5 = cc2 as BusinessAccount;
            cc4.Loan(54.0);
            Console.WriteLine(cc4);
        }
    }
}
