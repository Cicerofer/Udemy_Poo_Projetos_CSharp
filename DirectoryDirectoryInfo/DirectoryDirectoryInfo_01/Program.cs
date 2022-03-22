using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoryInfo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Proj_Pessoais\myfolder";

            try
            {
                var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);// lista pstas nesse caminho
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }


                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // lista todos os arquivos
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder"); // cria uma nova pasta "@ substitui a barra"
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }


        }
    }
}
