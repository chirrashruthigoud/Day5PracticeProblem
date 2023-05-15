using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblem
{
    public class MaxGeneric<T> where T : IComparable<T>
    {
        public void FindMax(int fValue, int sValue, int tValue)
        {
            if (fValue > sValue && fValue > tValue)
            {
                Console.WriteLine($"First Value is greater : {fValue}");
            }
            else if (sValue > fValue && sValue > tValue)
            {
                Console.WriteLine($"Second Value is greater : {sValue}");
            }
            else
            {
                Console.WriteLine($"Third value is greater : {tValue}");
            }
        }
        public void MaxFind(T fValue, T sValue, T tValue)
        {
            if (sValue.CompareTo(fValue) > 0 && sValue.CompareTo(tValue) > 0)
            {
                Console.WriteLine($"Second is greater : {sValue}");
            }
            else if (tValue.CompareTo(fValue) > 0 && tValue.CompareTo(sValue) > 0)
            {
                Console.WriteLine($"Third is greater : {tValue}");
            }
            else
            {
                Console.WriteLine($"first value is great : {fValue}");
            }
        }
    }
    
}
