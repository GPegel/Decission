using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decission
{
    class Program
    {
        static void Main(string[] args)
        {   //This is part one of the code, lines 13 / 16 is just one part and works
            //Console.WriteLine("Please type something and hit the Entery key");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            //This is a advanced part of the code, line 19 / 33 works
            Console.WriteLine("Would you prefer to know what is behind door 1, 2 or 3?");
            string userValue = Console.ReadLine();
            //string message = "";

            //if (userValue == "1")
            //    message = "You have a new car";
            //else if (userValue == "2")
            //    message = "You have a new boat";
            //else if (userValue == "3")
            //    message = "You have a new supersonice jetfighter!!! Yeah!";
            //else
            //    message = "You typed the wrong number you bastard!!!";

            //Console.WriteLine(message);
            //Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
            Console.ReadLine();


        }
    }
}
