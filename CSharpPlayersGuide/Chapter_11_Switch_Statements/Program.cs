using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try it Out
            Console.WriteLine("Making a Calculator");
            bool firstNumberValid = false, secondNumberValid = false, operationValid = false;
            double firstNumber = 0, secondNumber = 0;
            string operation = ""; 


            Console.WriteLine("Positive/Negative multiplication test");
            while (!firstNumberValid)
            {
                Console.WriteLine("Enter in a positive or negative number: ");
                try
                {
                    firstNumber = double.Parse(Console.ReadLine());
                    firstNumberValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid value entered, please enter a valid number");
                }
            }
            while (!secondNumberValid)
            {
                Console.WriteLine("Enter in another positive or negative number: ");
                try
                {
                    secondNumber = double.Parse(Console.ReadLine());
                    secondNumberValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid value entered, please enter a valid  number");
                }
            }
            // Check for resulting negative number logic
            Console.WriteLine($"Given firstNumber = {firstNumber} and secondNumber = {secondNumber}");
            Console.WriteLine("What operation do you want to perform?");
            while (!operationValid)
            {
                Console.WriteLine("Enter '+' for addition");
                Console.WriteLine("Enter '-' for subtraction");
                Console.WriteLine("Enter '/' for division");
                Console.WriteLine("Enter '*' for multiplication");
                Console.WriteLine("Enter '^' for Power");
                try
                {
                    operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "/" || operation == "*" || operation == "^")
                    {
                        operationValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation entered");
                    }
                }catch(Exception e)
                {
                    Console.WriteLine("Invalid Operation entered");
                }
            }
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case "/":       
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case "^":
                    Console.WriteLine($"{firstNumber} ^ {secondNumber} = {Math.Pow(firstNumber, secondNumber)}");
                    break;
                default:
                    Console.WriteLine("Something went wrong, should have never gotten here");
                    break;
            }
            Console.ReadKey();
        }
    }
}
