using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxElement
{
    public class MaximumNumber<T> where T : IComparable
    {
        public static T MaxNum(T first, T second, T third)
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
    }

}
