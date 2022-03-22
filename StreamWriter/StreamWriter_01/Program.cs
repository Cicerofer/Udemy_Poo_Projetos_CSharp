using System;
using System.IO;

namespace StreamWriter_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Proj_Pessoais\file1.txt";
            string targetPath = @"C:\Proj_Pessoais\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
