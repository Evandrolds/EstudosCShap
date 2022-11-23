using System;
using System.Globalization;

namespace EstruturaWhile;

class Application {
    public static void Main(String[] args) {

        Console.Write("Digite o numero para saber a rais quadrada...");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       
       
           
        while (x >= 0) {

            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            
            Console.WriteLine("Digite outro numero!");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
        Console.WriteLine(" Valor negativo! ");

    }
}
