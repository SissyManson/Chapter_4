using System;

namespace _11_Task_Numbers_in_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Enter number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
