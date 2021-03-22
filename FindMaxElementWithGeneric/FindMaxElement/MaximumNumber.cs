using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxElement
{
    public class MaximumNumber<T> where T : IComparable
    {
        //public T max;
        public MaximumNumber()
        {
            
        }
        public static T MaxNum(T[] array)
        {
            T temp;
            MaximumNumber<T> maximum = new MaximumNumber<T>();
            for (int i = 0; i < array.Length-1; i++)
            {
                //if (maximum.max?.CompareTo(array[i]) < 0)
                //    maximum.max = array[i];
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array[array.Length-1];
        }
    }

}
