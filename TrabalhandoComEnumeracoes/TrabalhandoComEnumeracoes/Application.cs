using TrabalhandoComEnumeracoes.Entities;
using TrabalhandoComEnumeracoes.Entities.Enuns;

namespace Apllication;

class Apllication
{
    static void Main(string[] args)
    {


        Order order = new Order
        {
            Id = 2,
            Moment = DateTime.Now,
            Status = OrderStatus.PaymentConfirmed
        };
        Console.WriteLine(order);
        // Convertendo um tipo enumrado para string
        string status = OrderStatus.Delivered.ToString();
        Console.WriteLine(status);

        // Convertendo um tipo OrderStatus para string
        // O parametro do Parse  que é uma string tem que existir e ser igual a do OrderStatus para que haja a converção
        OrderStatus os = Enum.Parse<OrderStatus>("PaymentConfirmed");
        Console.WriteLine(os);  
    }
}