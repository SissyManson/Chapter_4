using System;

namespace _10_Task_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter numbers count: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                sum += Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of all numbers is {0}.", sum);
        }
    }
}
