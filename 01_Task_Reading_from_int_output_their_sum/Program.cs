using System;

namespace _01_Task_Reading_from_int_output_their_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 numbers: \na= ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Their sum is: {0}",a+b+c);
        }
    }
}
