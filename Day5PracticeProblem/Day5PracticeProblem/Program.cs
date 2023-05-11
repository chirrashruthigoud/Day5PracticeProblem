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
            generic.FindMax(90,48,85);
            generic.FindMax(600, 800, 600);
            generic.FindMax(40, 600, 30);
            Console.ReadLine();
        }
    }
}
