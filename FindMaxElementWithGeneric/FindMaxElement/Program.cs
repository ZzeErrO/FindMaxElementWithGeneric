using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxElement
{
    public class Program
    {
        public static int MaximumIntegerNumber(int first, int second, int third)
        {
            if (first > second && first > third)
                return first;
            else if (second > first && second > third)
                return second;
            else if (third > first && third > second)
                return third ;
            else
                return first;
        }

        public static double MaximumDoubleNumber(double first, double second, double third)
        {
            if (first > second && first > third)
                return first;
            else if (second > first && second > third)
                return second;
            else if (third > first && third > second)
                return third;
            else
                return first;
        }

        public static string MaximumStringNumber(string first, string second, string third)
        {
            if (first.Length > second.Length && first.Length > third.Length)
                return first;
            else if (second.Length > first.Length && second.Length > third.Length)
                return second;
            else if (third.Length > first.Length && third.Length > second.Length)
                return third;
            else
                return first;
        }

        static void Main(string[] args)
        {
            int[] integer = { 3, 2, 0 };
            Console.WriteLine("MAXIMUM INTEGER");
            Console.WriteLine(MaximumIntegerNumber(integer[0], integer[1], integer[2]));
            Console.WriteLine("-----------------");
            double[] floatNumber = { 3.1, 22.5, 0.2 };
            Console.WriteLine("MAXIMUM DECIMAL");
            Console.WriteLine(MaximumDoubleNumber(floatNumber[0], floatNumber[1], floatNumber[2]));
            Console.WriteLine("-----------------");
            string[] stringNumber = { "Apple", "Peach", "Banana" };
            Console.WriteLine("MAXIMUM STRING");
            Console.WriteLine(MaximumStringNumber(stringNumber[0], stringNumber[1], stringNumber[2]));
            Console.WriteLine("-----------------");

            Console.ReadKey();

        }
    }
}
