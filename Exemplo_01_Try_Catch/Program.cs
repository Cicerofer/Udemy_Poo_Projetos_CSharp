using System;

namespace Exemplo_01_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um numero referente a N1: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um numero referente a N2: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException  )
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("format error! " + e.Message);
            }
           
        }
    }
}
