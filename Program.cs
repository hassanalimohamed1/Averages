using System;
using static System.Console;
namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 7, 6, 5, 4, 3, 2 };
            AvgCalc(23.56);
            AvgCalc(44.23, 55.28, 61.78);
            AvgCalc(26, 34, 84);
            AvgCalc(array);
        }
        static void AvgCalc(params double[] ary) {
            double total = 0;
            double avg;

            foreach (double number in ary) {
                Write(number + " ");
                total += number;
            }
            avg = total / ary.Length;
            WriteLine($" -- Average is {avg}.");
        }
    }
}
