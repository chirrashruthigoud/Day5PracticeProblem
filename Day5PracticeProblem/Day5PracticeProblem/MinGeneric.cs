using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblem
{
    public class MinGeneric
    {
        public void MinFind(int fValue, int sValue, int tValue)
        {
            if (fValue < sValue && fValue < tValue)
            {
                Console.WriteLine($"First Value is smaller : {fValue}");
            }
            else if (sValue < fValue && sValue < tValue)
            {
                Console.WriteLine($"Second Value is smaller : {sValue}");
            }
            else
            {
                Console.WriteLine($"Third value is smaller : {tValue}");
            }
        }

        //public class FindMinimum
        public void MinFindDouble(double fValue, double sValue, double tValue)
        {
            if (fValue < sValue && fValue < tValue)
            {
                Console.WriteLine($"First Value is smaller : {fValue}");
            }
            else if (sValue < fValue && sValue < tValue)
            {
                Console.WriteLine($"Second Value is smaller : {sValue}");
            }
            else
            {
                Console.WriteLine($"Third value is smaller : {tValue}");
            }
        }
    }
}
