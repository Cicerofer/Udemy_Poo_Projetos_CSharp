using System;
using System.IO;

namespace FileStream_StreamReader_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Proj_Pessoais\file1.txt";
          
            StreamReader sr = null;
            try
            {

                sr = File.OpenText(path);
                    while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
               
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu umerro");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();              

            }

        }
    }
}
