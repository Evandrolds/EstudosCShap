using System;
using System.Globalization;
namespace Application {

    class EquacaoSegundoGrau {

        public static void Main(string[] args) {


            string [] s = Console.ReadLine().Split(' ');
           
            string nome1 = s[0];
            string nome2 = s[1];
            string nome3 = s[2];
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);

            int n1 = int.Parse(Console.ReadLine());
            char n2 = char.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3.ToString("F2",CultureInfo.InvariantCulture));

            string [] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);

            Console.WriteLine("Nome: "+ nome);
            Console.WriteLine("Sexo: "+ sexo);
            Console.WriteLine("Idade: "+ idade);
        }
    }
}





