using System;

namespace _02_Task_Reads_r_output_perimeter_and_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of a circle: \nr= ");
            int r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("P of the cicle is {0} and S is {1}",2* Math.PI*r,Math.PI*r*r);
        }
    }
}
