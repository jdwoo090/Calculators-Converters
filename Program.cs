using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            //int num2 = 0;
            string val = "";

            WriteLine("Please Enter a Number: ");
            num = int.Parse(ReadLine());
            //WriteLine("Please Enter Another Number: ");
            //num2 = int.Parse(ReadLine());
            WriteLine("Is {0} your number?", num);
            if (ReadLine().ToString().ToLower() == "yes")
            {
                WriteLine("Ok, good! Here are your numbers: ");
                for (int m = 1; m <= num; m++)
                {
                    for(int n = 1; n <= m; n++)
                    {
                        Write(m + " ");
                    }
                    WriteLine();
                }
                ReadLine();
            }
            else
            {
                WriteLine("That's too bad, please try again later...");
            }
            ReadKey();
            /*for(int counter = 0; counter < 11; counter++)
            {
                WriteLine("{0}\t{1}\t{2}", counter, Math.Pow(counter, 2), Math.Pow(counter, 3));
            }
                ReadKey();*/
        }
    }
}
