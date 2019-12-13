using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutes;
            double hours;
            double seconds;
            string test;

            WriteLine("Please enter an amount of minutes so that we can convert them. Please no letters, spaces, words or commas.");
            test = ReadLine();

            try
            {
                minutes = int.Parse(test);
                seconds = minutes * 60;
                hours = minutes / 60;

                WriteLine(minutes + " minutes is exactly " + seconds + " seconds and " + hours + " hours.");
                ReadKey();
            }
            catch
            {
                WriteLine("Sorry, but that input is invalid");
                ReadKey();
            }
        }
    }
}
