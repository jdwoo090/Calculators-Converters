using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Iteration_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();
            Problem8();
            Problem9();
            Problem10();
            Problem11();
            Problem12();
            //Problem13();
            //Problem14();
            //Problem15();
            ReadKey();
        }
        static void Problem1()
        {
            for (int i = 0; i <= 10; i++)
            {
                WriteLine(i);
            }
        }
        static void Problem2()
        {
            int sum = 0;
            for (int i2 = 0; i2 <= 10; i2++)
            {
                sum = (sum + i2);
            }
            WriteLine(sum);
        }
        static void Problem3()
        {
            WriteLine("How many variables do you want?");
            int ans = int.Parse(ReadLine());
            int sum2 = 0;

            for (int i = 0; i <= ans; i++)
            {
                WriteLine(i);
                sum2 = (sum2 + i);
            }
            WriteLine(sum2);
        }
        static void Problem4()
        {
            WriteLine("How many variables do you want?");
            int ans2 = int.Parse(ReadLine());
            int sum3 = 0;

            for (int i = -1; i <= (ans2 * 2); i = i + 2)
            {
                WriteLine(i);
                sum3 = (sum3 + i);
            }
            WriteLine(sum3 + 1);
        }
        static void Problem5()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int i2 = 1; i2 < i; i2++)
                {
                    Write(i2);
                }
                WriteLine(i);
            }
        }
        static void Problem6()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int i2 = 1; i2 < i; i2++)
                {
                    Write(i);
                }
                WriteLine(i);
            }
        }
        static void Problem7()
        {
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int i2 = 1; i2 < i; i2++)
                {
                    Write(num++);
                }
                WriteLine();
            }
        }
        static void Problem8()
        {
            int num = -1;
            for (int i = 1; i <= 4; i++)
            {
                for (int i2 = 1; i2 < i; i2++)
                {
                    Write(num = num + 2);
                }
                WriteLine();
            }
        }
        static void Problem9()
        {
            WriteLine("Enter a number: ");
            int a = int.Parse(ReadLine());
            int product = 1;
            for (int i = a; i > 1; i--)
            {
                product *= i;
            }
            WriteLine(product);
        }
        static void Problem10()
        {
            WriteLine("Enter a number: ");
            int a = int.Parse(ReadLine());
            double tot = 1;
            for (double i = 1; i <= a; i++)
            {
                Write("1/" + i + " + ");
                tot = tot + ((1 / i));
            }
            WriteLine("");
            WriteLine("In total that is {0}!", (tot - 1));
        }
        static void Problem11()
        {
            WriteLine("How many series of nine would you like?");
            int a2 = int.Parse(ReadLine());
            string nine = "";
            int total = 0;
            for (int i = 1; i <= a2; i++)
            {
                nine = nine + "9";
                Write(" ");
                Write(nine);
                total += int.Parse(nine);
            }
            WriteLine("");
            WriteLine(total);
        }
        static void Problem12()
        {
            int odd = 0;
            int even = 0;
            for (int i = 1; i <= 4; odd++, even++)
            {
                if (odd == 1)
                {
                    WriteLine("01");
                }
                if (odd == 3)
                {
                    WriteLine("0101");
                }
                if (even == 0)
                {
                    WriteLine("1");
                }
                if (even == 2)
                {
                    WriteLine("101");
                }
                if (even == 4)
                {
                    WriteLine("10101");
                }
            }
        }
        /*static void Problem13() NOT FINISHED
        {
            int a = 1;
            for (int i = 1; i <= 5; i++)
            {
                WriteLine(a + "" + (i + a) + "" + a);
            }
        }
        static void Problem14() NOT FINISHED
        {
            WriteLine("How many series of nine would you like?");
            int a2 = int.Parse(ReadLine());
            for (int i = 1; i <= a2; i++)
            {

            }
        }
        static void Problem15() NOT FINISHED
        {
            WriteLine("How many series of nine would you like?");
            int a2 = int.Parse(ReadLine());
            for (int i = 1; i <= a2; i++)
            {

            }
        }*/
    }
}
