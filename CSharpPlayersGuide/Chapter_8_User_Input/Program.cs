using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Please Enter Some Text:");
             string whatTheUserTyped = Console.ReadLine();
             Console.WriteLine(whatTheUserTyped);*/

            double radius = 0d;
            double height = 0d;
            bool valid_entry = false;
            Console.WriteLine("Cylinders: A Complete Program");
            Console.WriteLine("_____________________________");
            while (!valid_entry)
            {
                Console.WriteLine("Please enter the radius of the cylinder:");
                try
                {
                    radius = double.Parse(Console.ReadLine()); // Could also use Convert.ToDouble();
                    valid_entry = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Value: Please enter a real number");
                }
            }

            valid_entry = false;
            while (!valid_entry)
            {
                Console.WriteLine("Please enter the height of the cylinder:");
                try
                {
                    height = double.Parse(Console.ReadLine()); // Could also use Convert.ToDouble();
                    valid_entry = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Value: Please enter a real number");
                }
            }

            Console.WriteLine($"The Volume of the Cylinder given a radius of {radius} and a height of {height} is: {(Math.PI * Math.Pow(radius, 2) * height):F2}");
            Console.WriteLine($"The Surface area of the Cylinder given a radius of {radius} and a height of {height} is: {(2d * Math.PI * radius * (radius + height)):F2}");

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Escape Characters");
            Console.WriteLine("_________________");
            Console.WriteLine("C:\\Users\\RB\\Desktop\\MyFile.txt"); // Escaping the "\" character
            Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt"); // "@" for string literals

            Console.ReadKey();
        }
    }
}
