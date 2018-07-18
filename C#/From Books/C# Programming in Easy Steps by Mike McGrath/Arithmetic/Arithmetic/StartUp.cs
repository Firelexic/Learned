using System;

namespace Arithmetic
{
    public class StartUp
    {
        public static void Main()
        {
            int a = 8;
            int b = 4;
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            int modulus = a % b;

            Console.WriteLine($"Addition : {addition}");
            Console.WriteLine($"Subtraction : {subtraction}");
            Console.WriteLine($"Multiplication : {multiplication}");
            Console.WriteLine($"Division : {division}");
            Console.WriteLine($"Modulus : {modulus}");

            Console.WriteLine("Postfix : " + (a++));
            Console.WriteLine("Postfix Result : " + a);

            Console.WriteLine("Prefix : " + (++b));
            Console.WriteLine("Prefix Resul : " + b);
        }
    }
}
