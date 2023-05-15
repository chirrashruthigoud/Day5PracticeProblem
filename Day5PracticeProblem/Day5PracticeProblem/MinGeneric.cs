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
        public void MinFindString(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.Length < secondValue.Length && firstValue.Length < thirdValue.Length)
            {
                Console.WriteLine($"First String is smaller : {firstValue}");
            }
            else if (secondValue.Length < firstValue.Length && secondValue.Length < thirdValue.Length)
            {
                Console.WriteLine($"Second String is smaller : {secondValue}");
            }
            else
            {
                Console.WriteLine($"Third value is smaller : {thirdValue}");
            }
        }
    }
}
