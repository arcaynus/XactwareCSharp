using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Creating_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int player_score; // declaring a variable
            player_score = 0; // initializing a variable
            int score = 3; // declaring and assigning a variable in one line

            Console.WriteLine(score); // Accessing the value of a variable to print;

            int a = 5;
            int b = 2;
            b = a; // Assign a copy of the value of "a" to variable "b"
            a = -3;
            Console.WriteLine($"a: {a} b:{b}");

            // Creating multiple variables on one line
            int A, B, C;
            A = B = C = 10;

            Console.ReadKey();
        }
    }
}
