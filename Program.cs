using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double base1;
            double base2;
            double radius;
            double width;
            double length;
            int name;

            WriteLine("Please choose to find the area of a circle, triangle, rectangle, trapezoid or the surface area of cylinder by typing 1, 2, 3, 4 or 5 for each of these (in order!)");
            name = int.Parse(ReadLine());

            switch (name)
            {
                case 1: WriteLine("1");
                    WriteLine("You have chosen circle, please enter a radius");
                    radius = double.Parse(ReadLine());
                    WriteLine("The circle's area is {0}. Thanks for using our program!", circle(radius));
                    break;
                case 2: WriteLine("2");
                    WriteLine("You have chosen triangle, please enter the height!");
                    height = double.Parse(ReadLine());
                    WriteLine("Now please enter the base's length!");
                    base1 = double.Parse(ReadLine());
                    WriteLine("The triangle has an area of {0}. Thanks for using our program!", triangle(height, base1));
                    break;
                case 3: WriteLine("3");
                    WriteLine("You have chosen a rectangle, please enter a length!");
                    length = double.Parse(ReadLine());
                    WriteLine("Now, please enter a width!");
                    width = double.Parse(ReadLine());
                    WriteLine("The rectangle has an area of {0}. Thanks for using our program!", rectangle(width, length));
                    break;
                case 4: WriteLine("4");
                    WriteLine("You have chosen a trapezoid, please enter a base!");
                    base1 = double.Parse(ReadLine());
                    WriteLine("Now, please enter the remaining base!");
                    base2 = double.Parse(ReadLine());
                    WriteLine("Now, please enter the height!");
                    height = double.Parse(ReadLine());
                    WriteLine("The trapezoid has an area of {0}. Thanks for using our program!", trapezoid(base1, base2, height));
                    break;
                case 5: WriteLine("5");
                    WriteLine("You have chosen a cylinder, please enter a radius!");
                    radius = double.Parse(ReadLine());
                    WriteLine("Now, please enter the height!");
                    height = double.Parse(ReadLine());
                    WriteLine("The cylinder has a surface area of {0}. Thanks for using our program!", cylinder(radius, height));
                    break;

                default: WriteLine("Please enter one of the actual numbers!");
                    break;
            }
            ReadKey();
        }
        public static double trapezoid(double base1, double base2, double height)
        {
            return ((base1 + base2) / 2) * height;
        }
        public static double circle(double radius)
        {
            return (Math.PI * (radius * radius));
        }
        public static double triangle(double height, double base1)
        {
            return (height * base1) / 2;
        }
        public static double rectangle (double width, double length)
        {
            return width * length;
        }
        public static double cylinder (double radius, double height)
        {
            return (2 * Math.PI * radius * height) + (2 * Math.PI * (radius * radius));
        } 
    }
}
