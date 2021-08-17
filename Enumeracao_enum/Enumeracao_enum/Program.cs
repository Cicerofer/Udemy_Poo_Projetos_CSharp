using Enumeracao_enum.Entities;
using System;
using Enumeracao_enum.Entities.Enums;


namespace Enumeracao_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendinPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendinPayment.ToString(); // conversão de string para inumeração
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");// conversão de inumeração para string
            Console.WriteLine(os);
        }
    }
}
