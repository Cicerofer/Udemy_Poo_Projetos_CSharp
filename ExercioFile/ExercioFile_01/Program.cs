using System;
using System.IO;
using System.Globalization;
using ExercioFile_01.Entities;

namespace ExercioFile_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();


            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);


                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"C:\Proj_Pessoais\myfolder\newfolder\out";
                string targetFilePath = targetFolderPath + @"C:\Proj_Pessoais\myfolder\newfolder\suamry.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFolderPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);
                            
                            sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
