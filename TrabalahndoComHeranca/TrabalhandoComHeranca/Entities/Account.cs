using System.Globalization;

namespace TrabalahndoComHeranca.Entities;
public class Account
{
    public string Holder { get; private set; }
    public int Number { get; private set; }
    public double Balance { get; protected set; }

    public Account(string holder, int number, double balance)
    {
        Holder = holder;
        Number = number;
        Balance = balance;
    }
    public Account() { }    
    public void Deposit(double amount)
    {
        Balance += amount;
    }
    public void WithDraw(double amount)
    {
        Balance -= amount;
    }

    public override string ToString()
    {
        return "\n Holder: " + Holder +
            "\n Number: " + Number +
            "\n Balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
    }
}