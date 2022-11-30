namespace WorkingWithDateTimeSpan;

class Application {
    static void Main(string[] args) {

        TimeSpan t1 = new TimeSpan(0, 1, 30);
        Console.WriteLine(t1);

        // Pegando o total do tempo em segundos 
        Console.WriteLine(t1.Ticks);


        TimeSpan t01 = new TimeSpan();

        // Pegando os segundo e convertendo em minutos 
        TimeSpan t2 = new TimeSpan(900000000L);

        // Passando horas, minutos e segundos
        TimeSpan t3 = new TimeSpan(2, 11, 21);

        // Passando dias, horas, minutos e segundos
        TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

        // Passando dias, horas, minutos, segundos e millésimos 
        TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);


        Console.WriteLine(t01);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5);

        Console.WriteLine("\n");

        // Métodos ( From )
        TimeSpan t6 = TimeSpan.FromDays(1.5);
        TimeSpan t7 = TimeSpan.FromHours(1.5);
        TimeSpan t8 = TimeSpan.FromMinutes(1.5);
        TimeSpan t9 = TimeSpan.FromSeconds(1.5);
        TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
        TimeSpan t11 = TimeSpan.FromTicks(900000000L);

        Console.WriteLine(" Um duia e meio: "+t6);
        Console.WriteLine(" Uma hora e meia: "+t7);
        Console.WriteLine(" Um minuto e meio: "+t8);
        Console.WriteLine(" Um segundo e meio: "+t9);
        Console.WriteLine(" Um millesegundo e meio: "+t10);
        Console.WriteLine(" Um minuto e meio: " +t11);
    }
}