using System;
using System.Globalization;
using PedidoUsuario.Entities;
using PedidoUsuario.Entities.Enums;

namespace PedidoUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.WriteLine("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());                
                
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}

/* Ler os dados de um pedido com N itens(N fornecido pelo usuário). Depois, mostrar um sumário do pedio conforme exemplo (próxima página).
 * Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now*/
