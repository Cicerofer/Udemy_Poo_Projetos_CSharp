using System;

namespace Hora_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = TimeSpan.FromDays(1.5);
            TimeSpan t3 = TimeSpan.FromHours(1.5);
            TimeSpan t4 = TimeSpan.FromMinutes(1.5);
            TimeSpan t5 = TimeSpan.FromSeconds(1.5);
            TimeSpan t6 = TimeSpan.FromMilliseconds(1);

            Console.WriteLine(t1);
            
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
