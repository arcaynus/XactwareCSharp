using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_More_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer Division
            int a = 7;
            int b = 2;
            int intResult = a / b;
            Console.WriteLine($"The Result of integer division of {a} / {b} = {intResult}");

            // Float division
            float d = 7f;
            float e = 2f;
            float floatResult = d / e;
            Console.WriteLine($"The Result of float division of {d} / {e} = {floatResult}");

            // Mixed Result
            Console.WriteLine($"The Mixed Result of integer division and float division of {a} / {b} + {d} / {e} = {a/b + d/e}");

            // Type Casting
            // Int to long Implicit Casting
            int _a = 4049;
            int _b = 284404039;
            long sum = _a + b; // no error (widening conversion _a is cast into a long

            int _a2 = 7;
            float _b2 = 2; // integer 2 is converted to 2.0 float value without adding the "f"
            float _result2 = _a2 / _b2; // _a2 is implicitely cast to a float to do division because 'b' is a float which means we get float division
            Console.WriteLine($"Result of integer division by float = {_result2}");

            // Explicit Conversion used for going from wider type to narrower type
            long _a3 = 3;
            int _b3 = (int)_a3;
            Console.WriteLine($"_b3 = {_b3}");

            // Try is out
            double _a4 = 1.0 + 1 + 1.0f;
            int x = (int)(7 + 3.0 / 4.0 * 2);
            Console.WriteLine((1 + 1)/2 * 3);

            // Infinity and such
            // Divide by zero
            int _forceDivideByZero = 0;
            try
            {
                Console.WriteLine($"Attempting to divide an integer by zero: {1/_forceDivideByZero}");
            }
            catch (DivideByZeroException exception)
            {

                Console.WriteLine($"Error message:{exception.ToString()}");
            }

            Console.WriteLine($"Divide a positive float by zero: {1.0f/_forceDivideByZero}");
            Console.WriteLine($"Divide a negative float by zero: {-1.0f / _forceDivideByZero}");
            Console.WriteLine($"Divide infinity by infinity: {double.PositiveInfinity / float.NegativeInfinity}");

            int _forceOverflow = 1;
            // Overflow and Underflow
            // Integer
            Console.WriteLine($"Overflow of integer max: {int.MaxValue + _forceOverflow}");
            Console.WriteLine($"Underflow of integer max: {int.MinValue - _forceOverflow}");
            
            // Floats
            float _forceOverflowFloat = 2f;
            Console.WriteLine($"Overflow of float max: {float.MaxValue + (_forceOverflowFloat * float.MaxValue)}");
            Console.WriteLine($"Underflow of float max: {float.MinValue - (_forceOverflowFloat * float.MaxValue)}");

            // Incrementing and Decrementing
            int _post = 0;

            Console.WriteLine($"Postfix Incrementing post: {_post++}");
            Console.WriteLine($"Prefix Incrementing post: {++_post}");
            Console.WriteLine($"Value of post after prefix: {_post}");
            Console.WriteLine($"Postfix Decrementing post: {_post--}");
            Console.WriteLine($"Prefix Decrementing post: {--_post}");
            Console.WriteLine($"Value of post after prefix: {_post}");

            Console.ReadKey();
        }
    }
}
