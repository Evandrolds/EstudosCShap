using System;
using System.Globalization;
namespace CalcularAreaDeDoisTriangulo_X_Y;
class Application {

    static void Main(string[] args) {

        double areaX,areaY, xa,xb,xc, ya,yb,yc, p;

        Console.WriteLine("Entre com as medidas de X ");
        xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine("Entre com as medidas de y ");
        ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        p = (xa + xb + xc) / 2;

        areaX = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc)); p = (xa + xb + xc) / 2;

        p = (ya + yb + yc) / 2;
        areaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));




       

        Console.WriteLine(" Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine(" Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture ));
        if (areaX > areaY) {
            Console.WriteLine("A maior area foi de X " + areaX.ToString("F4",CultureInfo.InvariantCulture));
        }
        else {
            Console.WriteLine("A maior area foi de Y " + areaY.ToString("F4",CultureInfo.InvariantCulture));
        }

    }
}
