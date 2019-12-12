using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace blank1211321321
{
    class Program
    {
        static void Main(string[] args)
        {
            //string aNumberValue;
            string mula;
            double euros;
            double dollars;
            //string ageValue;
            string mlHeight;
            int mileinch;
            //int aNumber;
            int mileInch;
            //int age;

            //Write("Enter a number: ");
            //aNumberValue = ReadLine();
            //aNumber = int.Parse(aNumberValue);
            //WriteLine("The square root of that number is " + Math.Sqrt(aNumber));
            //Write("Now, enter your age: ");
            //ageValue = ReadLine();
            //age = int.Parse(ageValue);
            //WriteLine("Your age next year will be {0} ", ++age);
            Write("Enter your value in miles: ");
            mlHeight = ReadLine();
            mileinch = int.Parse(mlHeight);
            mileInch = mileinch * 5280;
            WriteLine("Your value in inches is: " + mileInch + "in");
            Write("Please enter an amount in Euros: ");
            mula = ReadLine();
            euros = int.Parse(mula);
            dollars = euros * 1.11;
            WriteLine(euros + " euro is about " + dollars.ToString("C2"));



            Console.Read();
        }
        public static int inches(int feet)
        {
            return feet * 12;
        }
    }
}
