using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class H_Statement
    {
        public static void ShowStatement(string[] args)
        {
            bool isMan = true;
            bool isTall = true;
            if (isMan && isTall)
            {
                Console.WriteLine("You are a tall man");
            }
            else if (isMan && !isTall)
            {
                Console.WriteLine("You are a short man");
            }
            else if (!isMan && isTall)
            {
                Console.WriteLine("You are not man but you are tall");
            }
            else
            {
                Console.WriteLine("You are not man not tall");
            }

            // Switch statement
            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                default:
                    Console.WriteLine("It's another day!");
                    break;
            }

            // Ternary operator
            int age = 20;
            string result = (age >= 18) ? "You are an adult" : "You are a minor";
            Console.WriteLine(result);
        }
    }
}