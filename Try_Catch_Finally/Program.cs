using System;
using System.IO;

namespace Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\CURSO_ETL\Dados\Produtos.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }

            /*Fechar um arquivo ou conexão de banco de dados ao final do processamento*/

        }
    }
}
