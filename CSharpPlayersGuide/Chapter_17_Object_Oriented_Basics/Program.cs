using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17_Object_Oriented_Basics
{
    class Program
    {
        public enum Dice { d4 = 5, d6 = 7, d8 = 9, d10 = 11, d00 = 11, d20 = 21 };

        static void Main(string[] args)
        {
            bool _isQuit = false;
            bool _isValidAnswer = false;
            do
            {
                Console.WriteLine("Rolling the dice");

                Random random = new Random(); // Calls the Random class's no parameters constructor
                int aRandomNumber = random.Next(); // Calls the next method od the Random Class for the random instance
                //Console.WriteLine($"The value of aRandomNumber: {aRandomNumber}");

                int maxValue = 101;
                int aRandomNumber2 = random.Next(maxValue);
                //Console.WriteLine($"The value of aRandomNumber2 < {maxValue}: {aRandomNumber2}");

                //Simulating a dice roll
                Console.WriteLine($"Roll a {Dice.d4} result: {Program.rollDice(random, Dice.d4)}");
                Console.WriteLine($"Roll a {Dice.d6} result: {Program.rollDice(random, Dice.d6)}");
                Console.WriteLine($"Roll a {Dice.d8} result: {Program.rollDice(random, Dice.d8)}");
                Console.WriteLine($"Roll a {Dice.d10} result: {Program.rollDice(random, Dice.d10)}");
                Console.WriteLine($"Roll a {Dice.d00} result: {Program.rollDice(random, Dice.d00)}");
                Console.WriteLine($"Roll a {Dice.d20} result: {Program.rollDice(random, Dice.d20)}");

                try
                {
                    var answer = "";
                    _isValidAnswer = false;

                    while (!_isValidAnswer)
                    {
                        Console.WriteLine("Do you want to roll again? (y/n)");
                        answer = Console.ReadLine().ToLower();
                        if(answer.Equals("y") || answer.Equals("n"))
                        {
                            _isValidAnswer = true;
                            _isQuit = answer.Equals("n");
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            } while (!_isQuit);

        }
        public static int rollDice(Random rand, Dice type)
        {
            return rand.Next(0, (int)type);
        }
    }
}
