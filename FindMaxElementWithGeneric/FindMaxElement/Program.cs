using System;

namespace FindMaxElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SortedList<int,int> integer = new SortedList<int,int>();
            int[] integer = new int[]{ 5, 2, 20, 15, 60, 85, 61, 66, 5};
            //MaximumNumber<int> maxInt = new MaximumNumber<int>();
            Console.WriteLine("MAXIMUM INTEGER");
            Console.WriteLine(MaximumNumber<int>.MaxNum(integer));
            Console.WriteLine("-----------------");
            //SortedList<int, double> doubleNummber = new SortedList<int, double>();
            double[] doubleNumber = new double[] { 7.1, 6.5, 7.55, 83.5, 9.542, 8.888 };
            //MaximumNumber<double> maxDouble = new MaximumNumber<double>();
            Console.WriteLine("MAXIMUM DECIMAL");
            Console.WriteLine(MaximumNumber<double>.MaxNum(doubleNumber));
            Console.WriteLine("-----------------");
            string[] stringNumber = new string[]{ "7.7", "65", "755", "25", "9000"};
            //MaximumNumber<string> maxString = new MaximumNumber<string>();
            Console.WriteLine("MAXIMUM STRING");
            Console.WriteLine(MaximumNumber<string>.MaxNum(stringNumber));
            Console.WriteLine("-----------------");

            Console.ReadKey();

        }
    }
}
