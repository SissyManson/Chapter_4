using System;

namespace _05_Task_how_many_numbers_below
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата две цели числа (int) и
             * отпечатва колко числа има между тях, такива, че остатъкът им от
             * деленето на 5 да е 0. Пример: в интервала (17, 25) има 2 такива числа.*/

            int counter = 0;

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;
            }

            Console.WriteLine("{0} numbers found.", counter);
        }
    }
}
