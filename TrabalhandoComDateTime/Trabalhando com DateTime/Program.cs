using System.Globalization;

namespace WorkingWithDateTime;

class Apllication {
    static void Main(string[] args) {

        // Pegando a data e hora atual
        DateTime d1 = DateTime.Now;
        Console.WriteLine(d1);

        // Passando um padrao de data opcional convertendo para DateTime
        DateTime d2 = DateTime.Parse("1999-12-15");
        Console.WriteLine(d2);
        
        // Passando um padrao de data e hora opcional convertendo para DateTime
        DateTime d3 = DateTime.Parse("1999-12-15  09:58:35");
        Console.WriteLine(d3);

        // Data de Hoje
        DateTime d4 = DateTime.Today;
        Console.WriteLine(d4);

        // Pegando a data e hora com o fuso horario UTC do GMT lá no Benoit
        DateTime d5 = DateTime.UtcNow;
        Console.WriteLine(d5);

        //Passando uma formatação de data com a máscara no padrão americano
        DateTime d6 = DateTime.ParseExact("1900-11-12","yyyy-MM-dd",CultureInfo.InvariantCulture);
        Console.WriteLine(d6); 
        
        //Passando uma formatação de data e hora com a máscara no padrao brasileiro
        DateTime d7 = DateTime.ParseExact("11-12-1900 19:45:36" ,"dd-MM-yyyy HH:mm:ss",CultureInfo.InvariantCulture);
        Console.WriteLine(d7);  

    }
}
