using System;

namespace Modific_ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a); 
            Console.WriteLine(a);
        }
    }
}


/*Modificador "ref"   Suponha que se queira uma calculadora com uma opração para triplicar o valor de um número passado como parâmetro. 
A seguir uma solução que não funciona:


Class Calculator{
    public static void Triple(int x){     ---> public static void Tripli( ref int x)
          x = x * 3;
 

  class Program {
  static void Main( string[] args){
      int a = 10;
       Calculator.Triple(a);            ------> Calculator.Triple(ref a)
       Console.WriteLine(a);

    }
  }

   */
