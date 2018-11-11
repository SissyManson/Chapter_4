using System;

namespace _07_Task_Five_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            bool parseSucceed = false;

            do
            {
                Console.Write("Enter first number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out a);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter second number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter third number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fourth number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fifth number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);
        }
    }
}
