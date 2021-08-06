using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10;

            double a = x ?? 5; // Operador de coalescência nula
            double b = y ?? 5; //

            Console.WriteLine(a);
            Console.WriteLine(b);




            /*---------------------------------------------------------------------------------------------*/
            double? d= null;
            double? e = 10.0;
            Console.WriteLine(d.GetValueOrDefault());
            Console.WriteLine(e.GetValueOrDefault());

            Console.WriteLine(d.HasValue);
            Console.WriteLine(e.HasValue);


            if (d.HasValue) 
            {
                Console.WriteLine(d.Value); 
            }
            else
            {
                Console.WriteLine("D is null");
            }



            if (e.HasValue)
            {
                Console.WriteLine(e.Value);
            }
            else
            {
                Console.WriteLine("E is null");
            }


           
        }
    }
}
