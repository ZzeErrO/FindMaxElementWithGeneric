using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxElement
{
    public class Program
    {
        public static T MaxNum<T>(T first, T second, T third) where T : IComparable
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
                return first;
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                    second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) > 0 && third.CompareTo(second) > 0 ||
                    third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                return third;
            else
                return first;
        }

        static void Main(string[] args)
        {
            int[] integer = { 3, 2, 0 };
            Console.WriteLine("MAXIMUM INTEGER");
            Console.WriteLine(MaxNum<int>(integer[0], integer[1], integer[2]));
            Console.WriteLine("-----------------");
            double[] floatNumber = { 3.1, 22.5, 0.2 };
            Console.WriteLine("MAXIMUM DECIMAL");
            Console.WriteLine(MaxNum<double>(floatNumber[0], floatNumber[1], floatNumber[2]));
            Console.WriteLine("-----------------");
            string[] stringNumber = { "20", "65", "555" };
            Console.WriteLine("MAXIMUM STRING");
            Console.WriteLine(MaxNum<string>(stringNumber[0], stringNumber[1], stringNumber[2]));
            Console.WriteLine("-----------------");

            Console.ReadKey();

        }
    }
}
