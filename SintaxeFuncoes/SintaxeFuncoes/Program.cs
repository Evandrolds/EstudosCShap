using System;
namespace SintaxeFuncoes;
class funcoes {
    static void Main(string[] args) {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        Console.WriteLine(" O maior numero foi " +VerificarMaior(n1, n2, n3));
    }

    public static double VerificarMaior(int n1, int n2, int n3) {
        if (n1 > n2 && n2 > n3) {
            return n1;

        }
        else if (n1 < n2 && n2 > n3) {
            return n2;
        }
        else {
            return n3;
        }
    }
}

