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

            // Build a calculator - 
            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }
            // Display the result
            Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
        }
    }
}