using System;
using System.IO;

namespace Path01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Proj_Pessoais\myfolder\file1.txt";



            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));// mostra a localização da pasta
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);// mostra o que separa as pastas
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);// mostra o que separa entre as pastas
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));// mostra o nome do arquivo
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));// mostra o nome do arquivo sem a extenção
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));// mostra somente a extenção
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));// mostra o nome do arquivo
        }
    }
}
