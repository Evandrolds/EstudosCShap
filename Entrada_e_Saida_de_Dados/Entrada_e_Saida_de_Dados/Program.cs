using System;
namespace EntrataSaidaDados;
class Program {
    static void Main(string[] args) {

        //Console.WriteLine("Digite o seu nome...");
       // string nome = Console.ReadLine();
        //Console.WriteLine("Digite sua idade...");
        //int idade = int.Parse(Console.ReadLine());
        //Console.WriteLine("Digite seu sexo");
        //char sexo = char.Parse(Console.ReadLine());

       // Console.WriteLine(" Nome: " + nome);
       // Console.WriteLine(" Idade: " + idade);
       // Console.WriteLine(" Sexo: " + sexo);


        Console.WriteLine("Digite sue nome, idade e sexo");
        string[] dados = Console.ReadLine().Split(' ');
        
        string nome2 = dados[0];
        int idade2 = int.Parse(dados[1]);
        char sexo2 = char.Parse(dados[2]);

        Console.WriteLine("Nome2: " + nome2);
        Console.WriteLine("Idade: " + idade2);
        Console.WriteLine("sexo: " + sexo2);
    }
}
