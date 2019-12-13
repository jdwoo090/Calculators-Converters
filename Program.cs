using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VSCQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameResponse;
            string favoriteSaying;
            string agreement;

            WriteLine("Hello and welcome to our program! Before we begin, I need to warn you that this program will be asking for personal information like your name, are you okay with this? This information will not be saved or given away.");
            agreement = ReadLine();
            if (agreement.ToLower().Trim() == "no")
            {
                WriteLine("That is completely fine, and understandable! Please have a nice day and come back any time!");
                ReadKey();
            }
            else
            {
                WriteLine("Okay, that's great! Then let's get right into it!");
            WriteLine("What is your name?");
            nameResponse = ReadLine();
            WriteLine("I know this is a weird question, but do you have a favorite saying? For example, 'no pain no gain' or 'you miss 100% of the shots you don't take'. Do you have a favorite phrase that is something like that?");
            favoriteSaying = ReadLine();
                WriteLine("Okay! Thanks for your cooperation! This has been a lot of fun " + nameResponse + "! Remember, as the greats have always said " + favoriteSaying);
                WriteLine("That is all, thank you!");
                ReadKey();
            }
        }
    }
}
