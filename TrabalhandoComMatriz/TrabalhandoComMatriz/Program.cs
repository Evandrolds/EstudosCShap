﻿namespace Matriz;

class Application {

    public static void Main(String[] args) {

        int n = int.Parse(Console.ReadLine());
        int[,] mat = new int[n, n];

        for (int i = 0; i < n; i++) {
            string[] num = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++) {

                mat[i, j] = int.Parse(num[j]);
            }
        }
        Console.WriteLine(" Main diagonal: ");
        for (int i = 0; i < n; i++) {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine("\n");
        // Contar numeros negativo na Matriz
        int count = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {

                if (mat[i, j] < 0) {
                    count++;
                }
            }
        }
        Console.WriteLine(" Negative numbers " + count);
    }
}
