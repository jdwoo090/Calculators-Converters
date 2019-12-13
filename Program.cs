using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            string heightN;
            int width;
            string widthN;
            int areaF;
            WriteLine("Please enter the height of a rectangle in inches");
            heightN = ReadLine();
            WriteLine("Please enter the width of a rectangle in inches");
            widthN = ReadLine();
            height = int.Parse(heightN);
            width = int.Parse(widthN);
            areaF = height * width;
            WriteLine("The area of the rectangle is exactly " + areaF + " inches");
            ReadKey();
        }
    }
}
