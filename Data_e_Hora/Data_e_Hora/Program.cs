using System;
using System.Globalization;

namespace Data_e_Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:55");

            DateTime d3 = DateTime.Parse("2000/08/15");
           

            DateTime d4 = DateTime.ParseExact("2000/08/15", "yyyy- MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }
    }
}
/* DateTime d1 = new DateTime(2021, 08, 15);
            DateTime d2 = new DateTime(2021, 08, 15, 20, 19, 05);
            DateTime d3 = new DateTime(2021, 08, 15, 20, 31, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
*/