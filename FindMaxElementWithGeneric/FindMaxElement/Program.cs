using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] integer = { 3, 2, 0 };
            //MaximumNumber<int> maxInt = new MaximumNumber<int>();
            Console.WriteLine("MAXIMUM INTEGER");
            Console.WriteLine(MaximumNumber<int>.MaxNum(integer[0], integer[1], integer[2]));
            Console.WriteLine("-----------------");
            double[] floatNumber = { 3.1, 22.5, 0.2 };
            //MaximumNumber<double> maxDouble = new MaximumNumber<double>();
            Console.WriteLine("MAXIMUM DECIMAL");
            Console.WriteLine(MaximumNumber<double>.MaxNum(floatNumber[0], floatNumber[1], floatNumber[2]));
            Console.WriteLine("-----------------");
            string[] stringNumber = { "7", "65", "755" };
            //MaximumNumber<string> maxString = new MaximumNumber<string>();
            Console.WriteLine("MAXIMUM STRING");
            Console.WriteLine(MaximumNumber<string>.MaxNum(stringNumber[0], stringNumber[1], stringNumber[2]));
            Console.WriteLine("-----------------");

            Console.ReadKey();

        }
    }
}
