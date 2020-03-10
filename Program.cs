using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollarAMT;

            WriteLine("Hello, welcome to the program! Please enter an amount of USD to convert!");
            dollarAMT = double.Parse(ReadLine());
            WriteLine(dollarAMT + " USD should be " + toPounds(dollarAMT) + " pounds");
            ReadKey();
        }

        public static double toPounds(double dollars)
        {
            double pounds = dollars * 0.81;
            return pounds;
        }
    }
}
