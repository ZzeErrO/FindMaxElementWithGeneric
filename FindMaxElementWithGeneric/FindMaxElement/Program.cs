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

        static void Main(string[] args)
        {
            int[] integer = { 3, 2, 0 };
            Console.WriteLine("MAXIMUM INTEGER");
            Console.WriteLine(MaximumIntegerNumber(integer[0], integer[1], integer[2]));
            Console.WriteLine("-----------------");
            Console.ReadKey();

        }
    }
}
