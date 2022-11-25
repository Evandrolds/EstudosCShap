using System;
using System.Globalization;


using ProgramWithProperties;

namespace ProgramPOOwithProperties {
    class Application {
        public static void Main(string[] args) {

            Product p = new Product("Serra Marmore", "Ferramenta", 6, 389.90);
            Console.WriteLine(p.ToString());

        }

    }
}
