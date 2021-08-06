using System;
using System.Collections.Generic;
using System.Text;

namespace ModificaParans_Vetor
{
    class Calculator
    {

        public static int Sum( params int[] numbers){    //Uma função de vetor de numeros e calcula a soma dos numeros, colocando o modificador de pararametros --"Params"--.
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }


        /*Suponha que se queira uma calculadora para calcular a soma de uma quantidade variável de valores.
         * Solução ruim usando sobrecarga:*/


        // public static int Sum(int n1, int n2)
        //{
        //    return n1 + n2;
        //  }

        //public static int Sum(int n1, int n2, int n3)
        //{
        //   return n1 + n2 + n3;
        // }
        //
        // public static int Sum(int n1, int n2, int n3, int n4)
        //{
        //   return n1 + n2 + n3 + n4; 
        //}
    }
}
