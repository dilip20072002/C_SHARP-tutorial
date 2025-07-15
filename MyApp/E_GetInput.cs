using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class E_GetInput
    {
        public static void GetInput(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            // Console.WriteLine("Your name is " + name);

            Console.WriteLine("Please enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("My name is " + name + " and I am " + age + " years old.");
        }
    }
}