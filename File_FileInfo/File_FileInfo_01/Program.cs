using System;
using System.IO;

namespace File_FileInfo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Proj_Pessoais\file1.txt";       //caminho do arquivo de origem
            string targetPath = @"C:\Proj_Pessoais\file2.txt";        //camonho do arquivo de destino

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);  
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro");   // envia a mensagem de erro para o arquivo que você apountou
                Console.WriteLine(e.Message);
            }
        }
    }
}
