using System;

namespace Funcoes_Interessantes
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABCD abc DEFG     ";

            string s1 = original.ToUpper(); // converte para maísculo

            string s2 = original.ToLower(); // converte para minusculo

            string s3 = original.Trim(); // retira os espaços embraco no inicio e no fim, caso tenha

            int n1 = original.IndexOf("bc"); // mostra a primeira posição 

            int n2 = original.LastIndexOf("bc"); // mostra a ultima posição 

            string s4 = original.Substring(3); // recosta um pedaço da string

            string s5 = original.Substring(3, 5);  // recosta um pedaço da string, mostra inicio e fim

            string s6 = original.Replace('a', 'x'); // substitui uma caracter por outra

            string s7 = original.Replace("abc", "xy"); // substitui uma caracter por outra

            bool b1 = String.IsNullOrEmpty(original); //testa se astring é vazia,  se é nulo ou vazia

            bool b2 = String.IsNullOrWhiteSpace(original); // testa se é nulo ou deixou o spaço em branco



            Console.WriteLine("Original: -"+ original + "-");
            Console.WriteLine("Toupper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -"+ s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndeOf('bc'):" + n2 );
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}

/* * Formatar: ToLowe(), ToUpper(), Trim()
   * Buscar: IndexOf, LastIndexOf
   * Recortar: Substring(inicio), Substring(inicio, tamanho)
   * Substituir: Replace(char, char), Replace(string, string)
   * String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
   *str.Stlit('')
   *Conversão para numero: int x = int.Parse(str), int x = Convert.ToInt32(str)
   *Conversão de número: str = x.ToString(), str = x.ToString("C"), str = x.ToString("C3"), str = x.ToString("F2")*/
