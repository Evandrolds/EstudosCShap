using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeirProjetoPOO {
     class Triangulo {

        public double A;
        public double B;
        public double C;

        public double Somar(Triangulo t) {
            double p = (t.A + t.B + t.C) /2;

            double area = Math.Sqrt(p * (p - t.A) * (p - t.B) * (p - t.C));
            return area;
        }
    }
}
