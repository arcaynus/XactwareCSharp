using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {

            
            if (true)  // Using a straight true or false value, really never used unless forced for testing purposes
            {
                Console.WriteLine("This will always get called");
            }
            if (false)
            {
                Console.WriteLine("This will never get called");
            }

            bool isTrue = false;

            if (isTrue)  // Using a variable
            {
                Console.WriteLine($"Variable _isTrue is : {isTrue}"); // Wnhen true
            }
            else
            {
                Console.WriteLine($"Variable _isTrue is : {isTrue}"); //When false
            }

            int score = 0;

            Console.WriteLine("Enter your score: ");
            string scoreAsText = Console.ReadLine();
            try
            {
                score = Convert.ToInt32(scoreAsText);
                if (score == 100) // == is the equality comparason operator
                {
                    // Code between the curly braces is executed when the condition is true.                
                    Console.WriteLine("Perfect score! You win!");
                }
                else if (score == 99)
                {
                    Console.WriteLine("Misssed it by one point");
                }
                else if (score == 0)
                {
                    Console.WriteLine("You did not even spell your name right");
                }
                else
                {
                    Console.WriteLine("Try again, I was only checking for 100, 99, or 0");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"You did not enter a valid integer for score, you entered: {scoreAsText}");
            }

            // ******************** //
            // Relational Operators //
            // ******************** //

            Console.WriteLine("Enter your score again: ");
            scoreAsText = Console.ReadLine();
            try
            {
                score = Convert.ToInt32(scoreAsText);
                // Not equals
                if (score != 100)
                {
                    Console.WriteLine("Score Did not equal 100");
                }
                // Greater than
                if (score > 90)
                {
                    Console.WriteLine($"Score > 90, Score was: {score}");
                }
                // Greater than or equal to
                if (score >= 90)
                {
                    Console.WriteLine($"Score >= 90, Score was: {score}");
                }
                // Less than
                if (score < 60)
                {
                    Console.WriteLine($"Score was < 60, Score was: {score}");
                }
                // Less than or equal to
                if (score <= 60)
                {
                    Console.WriteLine($"Score was <= 60, Score was: {score}");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"You did not enter a valid integer for score, you entered: {scoreAsText}");
            }

            // Number to letter grade
            Console.WriteLine("Enter your score again to get your letter grade: ");
            scoreAsText = Console.ReadLine();
            try
            {
                score = Convert.ToInt32(scoreAsText);
                if (score == 100) Console.WriteLine("Perfect score! You win!");

                // This checks each condition in turn, until it finds the first one that             
                // is true, at which point, it executes the chosen code block, then jumps down             
                // to after the end of the whole if/else code.             
                if (score >= 90) Console.WriteLine("You got an A.");
                else if (score >= 80) Console.WriteLine("You got a B.");
                else if (score >= 70) Console.WriteLine("You got a C.");
                else if (score >= 60) Console.WriteLine("You got a D.");
                else Console.WriteLine("You got an F.");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"You did not enter a valid integer for score, you entered: {scoreAsText}");
            }

            // Relational operators return a boolean value

            var _bool = 10 > 50;
            Console.WriteLine($"The value of _bool is {_bool}");

            // ********************* //
            // Conditional Operators //
            // ********************* //
            bool _boolA = true, _boolB = true;

            if (_boolA && _boolB)
            {
                Console.WriteLine($"With an && conditional, both statements have to be true. _boolA: {_boolA}, _boolB: {_boolB}" );
            }
            _boolA = false;
            if (_boolA && _boolB)
            {
                Console.WriteLine($"With an && conditional, both statements have to be true. _boolA: {_boolA}, _boolB: {_boolB}");
            }
            if (_boolA || _boolB)
            {
                Console.WriteLine($"With an || conditional, only one statement has to be true. _boolA: {_boolA}, _boolB: {_boolB}");
            }
            _boolB = false;
            if (_boolA || _boolB)
            {
                Console.WriteLine($"With an || conditional, only one statement has to be true. _boolA: {_boolA}, _boolB: {_boolB}");
            }
            else
            {
                Console.WriteLine($"With an || conditional, if both statements are false, then the if statement will fail. _boolA: {_boolA}, _boolB: {_boolB}");

            }


            Console.WriteLine("Enter in a positive or negative number: ");
            scoreAsText = Console.ReadLine();
            try
            {
                score = Convert.ToInt32(scoreAsText);
                if (score == 100) Console.WriteLine("Perfect score! You win!");

                // This checks each condition in turn, until it finds the first one that             
                // is true, at which point, it executes the chosen code block, then jumps down             
                // to after the end of the whole if/else code.             
                if (score >= 90) Console.WriteLine("You got an A.");
                else if (score >= 80) Console.WriteLine("You got a B.");
                else if (score >= 70) Console.WriteLine("You got a C.");
                else if (score >= 60) Console.WriteLine("You got a D.");
                else Console.WriteLine("You got an F.");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"You did not enter a valid integer for score, you entered: {scoreAsText}");
            }

   


            // ********** //
            // Try it Out //
            // ********** //
            bool firstNumberValid = false, secondNumberValid = false;
            int firstNumber = 0, secondNumber = 0;


            Console.WriteLine("Positive/Negative multiplication test");
            while (!firstNumberValid)
            {
                Console.WriteLine("Enter in a positive or negative number: ");
                try
                {
                    firstNumber = int.Parse(Console.ReadLine());
                    firstNumberValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid value entered, please enter a valid integer number");
                }
            }
            while (!secondNumberValid)
            {
                Console.WriteLine("Enter in another positive or negative number: ");
                try
                {
                    secondNumber = int.Parse(Console.ReadLine());
                    secondNumberValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid value entered, please enter a valid integer number");
                }
            }
            // Check for resulting negative number logic
            Console.WriteLine($"Given firstNumber = {firstNumber} and secondNumber = {secondNumber}");

            if (firstNumber == 0 || secondNumber == 0)
            {
                Console.WriteLine("The result will be 0 and 0 is unsigned");
            }
            else if ( (firstNumber < 0 && secondNumber > 0) || (firstNumber > 0 && secondNumber < 0) )
            {
                Console.WriteLine("The result will be negative");
            }
            else
            {
                Console.WriteLine("The result will be positive");
            }


            // ******************** //
            // Conditional Operator //
            // ******************** //

            Console.WriteLine(true ? "Returned when conditional statement is true" : "Returned with conditional is false");
            Console.WriteLine(false ? "Returned when conditional statement is true" : "Returned with conditional is false");
            //Can be chained but gets ugly
            Console.WriteLine(5 < 10? 5 < 9? 5< 8? 5 < 7? "Five is less than 7": "Nope": "Nope": "Nope": "Nope" );

            if (true) // Single statements do not need curly braces
            Console.ReadKey();

        }
    }
}
