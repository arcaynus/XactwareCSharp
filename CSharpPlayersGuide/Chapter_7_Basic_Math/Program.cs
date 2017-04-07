using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Basic_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Area of a Triangle
            double _area, _base, _height = 0.0;
            _base = 20.0;
            _height = 22.3;
            _area = (1d / 2d) * _base * _height; // Have to add d to 1 and 2 so that we do not get integer math which 1/2 = 0;
            Console.WriteLine($"The area of a triangle with base of 20 and a height of 22.3 = {_area}");

            Console.WriteLine($"The area of a triangle with base of 5 and a height of 8 = {areaOfTriangle(5.0, 8.0)}");
            Console.WriteLine($"The area of a triangle with base of 3 and a height of 2 = {areaOfTriangle(3.0, 2.0)}");


            // Remainer
            int totalApples = 23;
            int people = 7;
            int remainingApples = totalApples % people;
            Console.WriteLine($"The remainder of apples after dividing the total number of apples: 23, by the total number of people: 3, is: {remainingApples}");

            // Remainder Try Out
            int _a = 10;
            int _b = 3;
            int _quotient = _a / _b;
            int _remainder = _a % _b;
            Console.WriteLine($"The quotient of int _a: {_a} / int _b {_b} is: {_quotient}");
            Console.WriteLine($"The remainder of int _a: {_a} % int _b {_b} is: {_remainder}");
            Console.WriteLine($"{_b * _quotient + _remainder}: should equal {_a}");

            // Unary Operators
            int _a1 = +3;
            int _b1 = -44;

            // Precedence
            double _a2 = 3.2;
            double _b2 = -4.3;
            double _c2 = 42;
            double _d2 = -91;
            double _e2 = 4.343;
            double result = (((_a2 + _b2) * (_c2 - 4)) + _d2) * _e2;
            Console.WriteLine($"The result is: {result}");

            // Compound Operators
            var _val = 4d;
            _val -= 3;
            Console.WriteLine($"This is the same as _val = _val - 3 {(_val == 1.0)}");
            _val *= 5;
            Console.WriteLine($"This is the same as _val = _val * 5 {(_val == 5.0)}");
            _val /= 4;
            Console.WriteLine($"This is the same as _val = _val / 4 {(_val == 1.25)}");
            _val %= 2;
            Console.WriteLine($"This is the same as _val = _val % 2 {(_val == 1.25)}");


            Console.ReadKey();
        }

        static double areaOfTriangle(double _base, double _height)
        {
            return .5 * _base * _height;
        }
    }
}
