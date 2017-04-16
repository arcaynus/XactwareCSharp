using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring an array
            int[] _intArray;
            // Initilizaing an array
            _intArray = new int[10];
            // Declaring an initializing an array on one line
            int[] _intArray2 = new int[10];
            // Declaring, initializing, and setting values
            int[] _intArray3 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] _intArray4 = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Accessing an index outside of the array length
            try
            {
                int val = _intArray3[_intArray3.Length + 1];
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }

            // re-initializing an array 
            _intArray = new int[11];
            // String array
            string[] _stringArray = new string[10];

            // Getting the size of the array
            Console.WriteLine($"The size of the _intArray: {_intArray.Length}");

            // Array's default values:
            Console.WriteLine($"Printing the contents of _intArray: {string.Join(", ", _intArray)}");
            Console.WriteLine($"Printing the contents of _stringArray: {string.Join(", ", _stringArray)}");

            // Setting  the contents of an array
            _intArray[0] = 1;
            // Initializing the contents of an array using a for loop
            for(int _count = 0; _count < _intArray.Length; _count++)
            {
                _intArray[_count] = _count;
              
            };
            Console.WriteLine($"Printing the contents of _intArray: {string.Join(", ", _intArray)}");

            Console.WriteLine("\nTry it Out 1");
            int[] _copyArray1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] _copyArray2 = new int[_copyArray1.Length];

            // Copy the values manually
            for(int _count = 0; _count < _copyArray1.Length; _count++)
            {
                _copyArray2[_count] = _copyArray1[_count];
            }
            Console.WriteLine($"Printing the contents of _copyArray2: {string.Join(", ", _copyArray2)}");


            Console.WriteLine("Another way to make a copy");
            _copyArray1 = new int[10] { 11,12,13,14,15,16,17,18,19,20};
            _copyArray2 = (int[])_copyArray1.Clone();
            Console.WriteLine($"Printing the contents of _copyArray2: {string.Join(", ", _copyArray2)}");

            // ************************ //
            // Multi-Dimensional Arrays //
            // ************************ //
            int[][] matrix = new int[4][]; // This is a jagged array
            matrix[0] = new int[4];
            matrix[1] = new int[5];
            matrix[2] = new int[2];
            matrix[3] = new int[6];

            // printing the values of a multi-dimensional array
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.Write($"Row {row}: ");
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }

            // setting values for multi-dimensional arrays
            for (int row = 0; row < matrix.Length; row++)
            {
                for(int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = row + col;
                }
            }

            Console.WriteLine();
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.Write($"Row {row}: ");
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Another way to write an array
            int[,] matrix2 = new int[4, 4];
            // First Row
            matrix2[0, 0] = 0;
            matrix2[0, 1] = 1;
            matrix2[0, 2] = 2;
            matrix2[0, 3] = 3;

            // Second row
            matrix2[1,0] = 4;
            matrix2[1, 1] = 5;
            matrix2[1, 2] = 6;
            matrix2[1, 3] = 7;

            // Third row
            matrix2[2, 0] = 8;
            matrix2[2, 1] = 9;
            matrix2[2, 2] = 10;
            matrix2[2, 3] = 11;

            // Fourth row
            matrix2[3, 0] = 12;
            matrix2[3, 1] = 13;
            matrix2[3, 2] = 14;
            matrix2[3, 3] = 15;


            // Fill in contents for multi-dimensional array  

            // Note: GetLength gives back the size of the multi-dimensional array for a specific index. 
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix2.GetLength(1); column++)
                {
                    Console.Write(matrix2[row, column] + " ");
                }
                    
            }

            Console.WriteLine();

            Console.WriteLine("Try Out 1");
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int currentMinimum = Int32.MaxValue; // We start high, so that any element in the array will be lower. 
            int currentMaximum = Int32.MinValue;
            int total = 0;

            foreach(int val in array)
            {
                if(val < currentMinimum)
                {
                    currentMinimum = val;
                }
            }
            foreach(int val in array)
            {
                if(val > currentMaximum)
                {
                    currentMaximum = val;
                }
            }
            foreach(int val in array)
            {
                total += val;
            }
            Console.WriteLine($"The maximum value is: {currentMaximum}");
            Console.WriteLine($"The minimum value is: {currentMinimum}");
            Console.WriteLine($"The average value is: {(double)total / (double)array.Length}");

            Console.ReadKey();


            
        }
       
    }
}
