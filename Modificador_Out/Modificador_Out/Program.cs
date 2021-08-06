using System;

namespace Modificador_Out
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            int triplo;
            Calculator.Triple(a, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
/*
 Omodificador out é similar ao ref ( faz o parâmetro ser uma referência para a variável original),
mas não exige que a variável original seja iniciada.

 
  Class Calculado {
       public static void Triple(int origin, out int result){
               result = origin * 3;
     }
  } 

   #----------------------------------------------------------------------#

 
     class Program {
        static void Main(string[] args){
           int a = 10;
           int triple;
           Calculator.Triple(a, out triple);
            Console.WriteLine*(triple);
       }
   }
 */