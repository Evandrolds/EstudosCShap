
using TrabalhandoComEnumeracoes.Entities.Enuns;

namespace TrabalhandoComEnumeracoes.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

      
        override
        public string ToString()
        {
            return " ID: " + Id +
                "\n Moment: " + Moment +
                "\n Order Status: " + Status;
        }

    }
}
