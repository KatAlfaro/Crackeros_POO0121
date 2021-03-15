using System;

namespace Modificacion1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

             Console.WriteLine($"Subtracting {a} - {b} equals {SubNumbers(a,b)} ");

        }

        public  static int SubNumbers(int a, int b)
        {
            return a * b;
        }
    }
}