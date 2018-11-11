using System;

namespace _06_Task_The_bigger_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} >= {1}", Math.Max(a, b), Math.Min(a, b));
        }
    }
}
