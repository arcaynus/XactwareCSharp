using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the CountToTen() method
            CountTo();
            // Print out something awesome
            Console.WriteLine(SaySomethingAwesome());
            Console.WriteLine("I am outside a method");
            InsideAMethod();
            Console.WriteLine("I am outside a method again");
            CountTo(40);
            CountTo(1, 10);

            Console.WriteLine();
            // Try Out 1
            Console.WriteLine("Try it Out! 1");

            int[] numbers = GenerateNumbers(11);
            PrintNumbers(numbers);
            Reverse(numbers);
            Console.WriteLine();
            PrintNumbers(numbers);


            Console.WriteLine($"1! = {Factorial(1)}");
            Console.WriteLine($"5! = {Factorial(5)}");

            Console.WriteLine($"Fibonacci(3) = {Fibonacci(3)}");
            Console.WriteLine($"Fibonacci(3) = {Fibonacci(8)}");

            Console.ReadLine();
        }

        private static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}:{numbers[i]}");
            }
        }

        private static void Reverse(int[] numbers)
        {
            for (int i = 0; i < numbers.Length/2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
        }

        private static int[] GenerateNumbers(int size = 10, bool randNum = false)
        {
            
            Random random = new Random((int)(DateTime.Now - DateTime.MinValue).TotalSeconds);
            int[] array = new int[size];
            // Populate the index with random values
            if (randNum)
            {
                for (int i = 0; i < size; i++)
                {
                    array[i] = random.Next(int.MinValue, int.MaxValue);
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    array[i] = i;
                }
            }
            return array;
        }
        /// <summary>
        /// Prints out numbers 1 to 10 on the Console 
        /// </summary>
        static void CountTo()
        {
            var index = 1;
            for(;index <= 10;)
            {
                Console.WriteLine($"Index: {index++}");
            }
        }
        /// <summary>
        /// Prints out numbers starting at 1 to countTo
        /// </summary>
        /// <param name="countTo">Number to count to (inclusive)</param>
        static void CountTo(int countTo)
        {
            var index = 1;
            for (; index <= countTo;)
            {
                Console.WriteLine($"Count: {index++}");
            }
        }
        //Overloaded Method - Different number of params
        /// <summary>
        /// Prings out numbers starting from to to
        /// </summary>
        /// <param name="from">Staring count</param>
        /// <param name="to">Ending count (inclusive)</param>
        static void CountTo(int from, int to)
        {
            Console.WriteLine($"Counting {from} - {to}");
            var index = from;
            for (; index <= to;)
            {
                Console.WriteLine($"Count: {index++}");
            }
        }
        static void InsideAMethod()
        {
            Console.WriteLine("I am inside a method");
        }
        static string SaySomethingAwesome()
        {
            return "Just Keep Swimming, Just Keep Swimming";
        }

        static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        static int Fibonacci(int n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
