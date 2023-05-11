using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblem
{
    public class MaxGeneric<T> where T : IComparable<T>
    {
        public void FindMax(T fValue, T sValue, T tValue)
        {
            if (sValue.CompareTo(fValue) > 0 && sValue.CompareTo(tValue) > 0)
            {
                Console.WriteLine($"Second is gretaer : {sValue}");
            }
            else if (tValue.CompareTo(fValue) > 0 && tValue.CompareTo(sValue) > 0)
            {
                Console.WriteLine($"Third is gretaer : {tValue}");
            }
            else
            {
                Console.WriteLine(fValue);
            }
            
         }
    }
}
