using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConSOLELLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";

            WriteLine("This program gets the average of a set of numbers, so how many numbers do you want to enter?");
            answer = ReadLine();

            double[] myDoubles = new double[int.Parse(answer)];
            double sum = 0;


            for (int i = 0; i < myDoubles.Length; i++)
            {
                WriteLine("Enter a number please");
                myDoubles[i] = double.Parse(ReadLine());
            }

            foreach (double item in myDoubles)
            {
                sum = sum + item;
            }

            WriteLine("The average is {0:N2}", sum / int.Parse(answer));
            ReadLine();
        }
    }
}