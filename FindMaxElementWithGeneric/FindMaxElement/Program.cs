using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxElement
{
    class Program
    {
        public static void MaximumIntegerNumber(int first, int second, int third)
        {
            if (first > second && first > third)
                Console.WriteLine(first);
            else if (second > first && second > third)
                Console.WriteLine(second);
            else if (third > first && third > second)
                Console.WriteLine(third);
            else
                Console.WriteLine(first);
            Console.WriteLine("-----------------");
        }

        static void Main(string[] args)
        {
            int[] integer = { 3, 2, 0 };
            Console.WriteLine("MAXIMUM INTEGER");
            MaximumIntegerNumber(integer[0], integer[1], integer[2]);
            Console.ReadKey();

        }
    }
}
