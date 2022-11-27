using System.Collections;
namespace Listas;

class Application {

    public static void Main(String[] args) {

        List<string> names = new List<string>();

        // Adding elelements
        names.Add("Sandro");
        names.Add("Pedro");
        names.Add("Pamela");
        names.Add("Maria");
        names.Add("Mendonsa");
        ReadName(names);
        Console.WriteLine("\n");

        // Adding in a certain position
        names.Insert(1, "Alesandro");
        ReadName(names);

        Console.WriteLine("\n");

        // Finding name that start with ( P )
        string name = names.Find((x) => x.StartsWith("P"));
        Console.WriteLine(name);

        Console.WriteLine("\n");

        // Find first element
        string firstName = names.FirstOrDefault();
        Console.WriteLine(" First name " + firstName);

        // Get Last element
        string lastName = names.LastOrDefault();
        Console.WriteLine(" Last name " + lastName);

        Console.WriteLine("\n");

        // Get element index 
        int indexName = names.FindIndex(x => x[0] == 'M');
        Console.WriteLine(" First index starts with M " + indexName);

        Console.WriteLine("\n");

        //Get Last index elements 
        int lastIndex = names.FindLastIndex(x => x[0] == 'M');
        Console.WriteLine(" Last index starts with M " + lastIndex);

        Console.WriteLine("\n");

        // Get All Elements that start with M
        List<string> another = new List<string>();
        another.AddRange(names.FindAll((x) => x.StartsWith("M")));
        another.ForEach((x) => Console.WriteLine(x));

        Console.WriteLine("\n");
        // Removing elements
        names.Remove("Maria");
        names.ForEach((x) => Console.WriteLine(x));

        Console.WriteLine("\n");
        // Removing all
        names.RemoveAll(x => x.StartsWith("P"));
        names.ForEach((x) => Console.WriteLine(x));

        Console.WriteLine("\n");
        // Remove with At
        names.RemoveAt(2);
        names.ForEach((x) => Console.WriteLine(x));

        List<string> names2 = new List<string>();
        names2.Add("Sandro");
        names2.Add("Pedro");
        names2.Add("Pamela");
        names2.Add("Maria");
        names2.Add("Mendonsa");

        Console.WriteLine("\n");
        // Remove with Range
        names2.RemoveRange(1, 3);
        names2.ForEach((x) => Console.WriteLine(x));
    }

    public static void ReadName(List<string> names) {
        names.ForEach((x) => Console.WriteLine(x));

    }


}
