using PrimeirProjetoPOO;
using System;
using System.Globalization;

namespace CalcularAreaDoTriangulo_X_Y;
class Application {
    static void Main(string[] args) {
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com os valores de X");
        x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine(  "Area X " + x.Calcular().ToString("F4", CultureInfo.InvariantCulture));

        Console.WriteLine("Entre com os valores de Y");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine(  "Area X " + y.Calcular().ToString("F4",CultureInfo.InvariantCulture));
    }
}