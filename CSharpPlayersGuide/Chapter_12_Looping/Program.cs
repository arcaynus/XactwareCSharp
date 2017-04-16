using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            // *********** //
            // While Loops //
            // *********** //

            // Simple Example 
            Console.WriteLine("While Count");
            int _count1 = 0;
            while (_count1 <= 10)
            {
                Console.WriteLine($"Count: {_count1++}");
            }

            // Infinite loop
            const bool _true = true;
            const bool _false = false;

            /*
            while (_true)
            {
                //This will never end do not do this
            }
            */

            // Loop that will never execute
            while (_false)
            {
                // Code here will never run
            }

            // ************** //
            // Do While Loops //
            // ************** //

            do
            {
                Console.WriteLine("Unlike while loops, do while loops are executed before the check");
            } while (_false);

            Console.WriteLine("Do While Count");
            _count1 = 0;
            do
            {
                Console.WriteLine($"Count: {_count1++}");
            } while (_count1 <= 10);


            // ********* //
            // For Loops //
            // ********* //

            Console.WriteLine("Basic For Loop Count");
            for(_count1 = 0; _count1 <= 10; _count1++)
            {
                Console.WriteLine($"Count: {_count1}");
            }
            _count1 = 0;
            Console.WriteLine("For Loop with out init statement");
            for(;_count1 <= 10; _count1++)
            {
                Console.WriteLine($"Count: {_count1}");
            }
            _count1 = 0;
            Console.WriteLine("For Loop with out init or action statement");
            for (;_count1 <= 10;)
            {
                Console.WriteLine($"Count: {_count1++}");
            }
            _count1 = 0;
            Console.WriteLine("For Loop with out any statement and break statenent");
            for (; ; )
            {
                Console.WriteLine($"Count: {_count1++}");
                if(_count1 > 10)
                {
                    break; // Break out of loop
                }
            }
            Console.WriteLine("For Loop with Continue statement");
            _count1 = 0;
            for (; _count1 <= 10; _count1++)
            {
                if(_count1 % 2 == 1 || _count1 == 0)
                {
                    continue;
                }
                Console.WriteLine($"Count: {_count1}");
            }

            // Try it Out 1
            Console.WriteLine("Try it Out Exercse 1");
            var rowCount = 20;
            for(int row = 0; row < rowCount; row++)
            {
                //Write blanks
                for(int space = 0; space < rowCount - row - 1; space++)
                {
                    Console.Write(" ");
                }
                //Write stars
                for(int star = 0; star < row * 2 + 1; star++)
                {
                    Console.Write("*");
                }
                //Terminate the line
                Console.Write("\n");
            }

            Console.WriteLine("\n\nTry it Out Exercise 2");
            for(_count1 = 1; _count1 <= 100; _count1++)
            {
                if(_count1 % 3 == 0 && _count1 % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (_count1 % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if(_count1 % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write($"{_count1}");
                }
                if(_count1 < 100)
                Console.Write(" ");
            }

            Console.ReadKey();

        }
        
    }
}
