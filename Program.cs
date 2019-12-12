//using static BIGBOY collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Method_Quiz_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double height;

            WriteLine("Please enter the length of a rectangular prism");
            length = double.Parse(ReadLine());
            WriteLine("Please enter the width of a rectangular prism");
            width = double.Parse(ReadLine());
            WriteLine("Please enter the height of a rectangular prism");
            height = double.Parse(ReadLine());

            WriteLine("The surface area of the rectangular prism is {0} units!", SA(length, width, height));

            ReadKey();
        }
        public static double SA (double l, double w, double h)
        {
            return (2 * ((l * w) + (l * h) + (h * w)));
        }
    }
}
