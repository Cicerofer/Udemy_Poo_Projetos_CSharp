using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite u numero referente ao dia: ");
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1: 
                    day = "Sundey";
                    break;
                case 2: 
                    day = "Mondey";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;                       


            }

            Console.WriteLine("Day: " + day);
        }


        /* int x = int.Parse(Console.REadline());
         string day;
        
         if(x == 1){
            day = "Sunday";
        }
        else if (x == 2){
            day = "Monday";
        }
        else if (x == 3){
            day = "Tuesday";
        }
        else if (x == 4){
            day = "Wednesday";
        }
        else if (x == 5){
            day = "Thursday";
        }
        else if (x == 6){
            day = "Friday";
        }
        else if (x == 7){
            day = "Saturday";
        }
        else {
            day = "Invalid Value";
        }
        
         Console.ReadLine("Day: " + day);   */
    }
}
