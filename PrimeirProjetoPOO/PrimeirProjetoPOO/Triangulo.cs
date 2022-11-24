using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeirProjetoPOO {
     class Triangulo {

        public double A;
        public double B;
        public double C;

        public double Calcular() {
            double p = (A + B + C) /2;

           return  Math.Sqrt(p * (p - A) * (p - B) * (p - C));
           
        }
    }
}
