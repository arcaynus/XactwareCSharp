using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14_Enumerations
{
    class Program
    {
        // You define enumerations directly in the namespace.     
        enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }; 
        enum MonthsOfYear { January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12}

        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Saturday;
            Console.WriteLine($"The value of today is: {today.ToString()}");
            Console.WriteLine($"The value of today is: {(int)today}");

            Console.WriteLine();

            Console.WriteLine($"Try Out 1");
            bool validEntry = false;
            do
            {
                Console.WriteLine("Please Enter a Month Number between (1-12)");
                int entry;
                try
                {
                    entry = int.Parse(Console.ReadLine());
                    if(entry < 1 || entry > 12)
                    {
                        continue;
                    }
                    validEntry = true;
                    Console.WriteLine((MonthsOfYear)entry);
                }catch(Exception e)
                {
                    continue;
                }
                

            } while (!validEntry);

            

            Console.ReadKey();
        }
    }
}
