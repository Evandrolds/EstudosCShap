
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
        }
    }
}
