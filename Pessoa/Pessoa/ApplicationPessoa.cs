using dados_de_pessoa;
using System;
using System.Globalization;

namespace ApplicationPessoa {

    class Application {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa("Sandro", 36);
            Console.WriteLine(p1.ToString());

            Pessoa p2;

            p2 = new Pessoa("Evandro", 23);

            Console.WriteLine(p2.ToString());

            // Verificar quem é mais velho
            Console.WriteLine("O mais velho dentre as pessoas é " + VerificarMaior(p1, p2));

        }
        // Metodo de verificação de idade
        public static string VerificarMaior(Pessoa pessoa1, Pessoa pessoa2) {


            if (pessoa1.GetIdade() > pessoa2.GetIdade()) {
                return pessoa1.GetNome();
            }
            else {
                return pessoa2.GetNome();
            }

        }

    }
}
