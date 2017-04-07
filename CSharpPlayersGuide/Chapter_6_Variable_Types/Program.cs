using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Variable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Itegral Types
            byte _byte = 1;
            sbyte _sbyte = -1;

            short _short = 2; 
            ushort _ushort = 3;

            int _int = -4;
            uint _uint = 4U;

            long _long = -23L;
            ulong _ulong = 1_111_111LU;

            char _char = 'a';


            // Byte Info
            Console.WriteLine($"byte: Range {byte.MinValue} - {byte.MaxValue}, Size: {sizeof(byte)} Byte ({sizeof(byte) * 8} bits)");
            Console.WriteLine($"byte Value:{_byte}");

            Console.WriteLine($"sbyte: Range {sbyte.MinValue} - {sbyte.MaxValue}, Size: {sizeof(sbyte)} Byte ({sizeof(sbyte) * 8} bits)");
            Console.WriteLine($"sbyte Value:{_sbyte}");
            
            // Short Info
            Console.WriteLine($"short: Range {short.MinValue} - {short.MaxValue}, Size: {sizeof(short)} Bytes ({sizeof(short) * 8} bits)");
            Console.WriteLine($"short Value:{_short}");
            
            Console.WriteLine($"ushort: Range {ushort.MinValue} - {ushort.MaxValue}, Size: {sizeof(ushort)} Bytes ({sizeof(ushort) * 8} bits)");
            Console.WriteLine($"ushort Value:{_ushort}");
            
            // Int Info
            Console.WriteLine($"int: Range {int.MinValue} - {int.MaxValue}, Size: {sizeof(int)} Bytes ({sizeof(int) * 8} bits)");
            Console.WriteLine($"int Value:{_int}");

            Console.WriteLine($"uint: Range {uint.MinValue} - {uint.MaxValue}, Size: {sizeof(uint)} Bytes ({sizeof(uint) * 8} bits)");
            Console.WriteLine($"_uint Value:{_uint}");

            // Long Info
            Console.WriteLine($"int: Range {long.MinValue} - {long.MaxValue}, Size: {sizeof(long)} Bytes ({sizeof(long) * 8} bits)");
            Console.WriteLine($"int Value:{_long}");

            Console.WriteLine($"uint: Range {ulong.MinValue} - {ulong.MaxValue}, Size: {sizeof(ulong)} Bytes ({sizeof(ulong) * 8} bits)");
            Console.WriteLine($"_uint Value:{_ulong}");

            // Char Info
            Console.WriteLine($"char: Range {char.MinValue} - {char.MaxValue}, Size: {sizeof(char)} Bytes ({sizeof(char) * 8} bits)");
            Console.WriteLine($"char Value:{_char}");

            // Real Numbers
            
            // Decimal Info
            decimal _decimal = 2.3M;
            Console.WriteLine($"Decimal: Range {decimal.MinValue} - {decimal.MaxValue}, Size: {sizeof(decimal)} Bytes ({sizeof(decimal) * 8} bits)");
            Console.WriteLine($"Decimal Value:{_decimal}");

            // Float Info
            float _float = 2.32f;
            Console.WriteLine($"Float: Range {float.MinValue} - {float.MaxValue}, Size: {sizeof(float)} Bytes ({sizeof(float) * 8} bits)");
            Console.WriteLine($"Float Value:{_float}");

            // Double Info
            double _double = 2.32;
            Console.WriteLine($"Double: Range {double.MinValue} - {double.MaxValue}, Size: {sizeof(double)} Bytes ({sizeof(double) * 8} bits)");
            Console.WriteLine($"Double Value:{_double}");

            // Boolean

            bool _true = true;
            bool _false = false;

            Console.WriteLine($"Boolean Size: {sizeof(bool)} Bytes ({sizeof(bool) * 8} bits)"); // 1 byte because it is the smallest addressable size
            Console.WriteLine($"True Value:{_true}");
            Console.WriteLine($"False Value:{_false}");

            // Type Inference
            var _string = "Hello World";
            string _string2 = _string;

            Console.WriteLine($"String value: {_string}");
            Console.WriteLine($"String2 value: {_string2}");
            Console.WriteLine($"Type of var: {_string.GetType()}"); 

            Console.ReadKey();

        }
    }
}
