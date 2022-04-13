using System;
using System.Globalization;
using Interfaces_01.Entities;
using Interfaces_01.Services;

namespace Interfaces_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy  hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy  hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.CurrentUICulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}

/*
 Uma locadora brasileira de carros cobra um valor por hora para locações de até 12 horas. 
Porém, se a duração da locação ultrapassar 12 horas, a locação será cobrada com base em um valor diário. 
Além do valor da locação, é acrecido no preço o valor do imposto conforme regras do país que, no caso do Brasil,
é 20% para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um progrma que lê os dados da locação 
(modelo do carro, instante inicial e final da locação), bem como o valor do imposto e valor total do pagamento)
e informar os dados na tela. Veja os exemplos.

Primeiro EX:

Calculations :
Duration = (25/06/2018 14:40) - (25/06/2018 10:30)  = 4:10 5 hours
Basic payment = 5 * 10 = 50
tax = 50 * 20% = 50 * 0.2 = 10

 */
