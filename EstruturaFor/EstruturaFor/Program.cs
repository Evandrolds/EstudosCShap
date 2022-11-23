using System;
using System.Globalization;
namespace EstruturaFor;
class Application {
    public static void Main(string[] args) {

        Console.WriteLine(" Digite um número!");
        int n = int.Parse(Console.ReadLine());
        double soma = 0.0;
        for (int i = 1; i <= n; i++) {
            Console.WriteLine("Digite o " + i +"º Numero");
            double x = double.Parse(Console.ReadLine());
            soma += x;
        }
        Console.WriteLine("Valor da soma é " + soma);
    }
}
