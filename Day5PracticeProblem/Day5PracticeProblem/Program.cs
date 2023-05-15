using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MaxGeneric<int> generic = new MaxGeneric<int>();
            MaxGeneric<double> findMax = new MaxGeneric<double>();
            generic.MaxFind(20, 300, 50);
            findMax.MaxFind(31.08, 201.52, 64.311);
            generic.MaxFind(2002, 300, 50);
            findMax.MaxFind(18.08, 45.01, 600.32);
            generic.MaxFind(2000, 300, 5000);
            findMax.MaxFind(804.08, 90.00, 51.32);
            generic.FindMax(20, 30, 50);
            Console.ReadLine();
        }
    }
}
