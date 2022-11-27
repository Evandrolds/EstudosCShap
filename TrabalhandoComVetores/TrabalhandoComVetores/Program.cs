using TrabalhandoComVetores;

namespace Vetores;

public class Application {
    static void Main(string[] args) {

        Console.Write("How many people are there.... ");

        int n = int.Parse(Console.ReadLine());
        Student[] bed = new Student[10];

        for (int i = 1; i <= n; i++) {

            Console.WriteLine("Enter " + i +"º  Name...");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age.... ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter room....  ");
            int room = int.Parse(Console.ReadLine());

            bed[room] = new Student(name, age, room);

           

        }
        for (int i=0; i <= 10; i++) {
            if (bed[i]!= null) {

            Console.WriteLine(i + ": " + bed[i]);

            }

        }

    }
}
