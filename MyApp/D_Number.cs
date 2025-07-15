using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class D_Number
    {
        public static void ShowNumber(string[] args)
        {
            Console.WriteLine("This is a number demonstration.");
            int number = 100;
            double decimalNumber = 99.99;
            float floatNumber = 45.67f;

            Console.WriteLine($"Integer: {number}");
            Console.WriteLine($"Double: {decimalNumber}");
            Console.WriteLine($"Float: {floatNumber}");
            
            // Additional number operations
            int sum = number + 50;
            double product = decimalNumber * 2;
            float division = floatNumber / 2;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Division: {division}");

            // Displaying the type of each number
            Console.WriteLine($"Type of number: {number.GetType()}");
            Console.WriteLine($"Type of decimalNumber: {decimalNumber.GetType()}");
            Console.WriteLine($"Type of floatNumber: {floatNumber.GetType()}");
            Console.WriteLine($"Type of sum: {sum.GetType()}");
            Console.WriteLine($"Type of product: {product.GetType()}");
            Console.WriteLine($"Type of division: {division.GetType()}");

            Console.WriteLine(Math.PI); // Displaying the value of Pi
            Console.WriteLine(Math.Sqrt(16)); // Displaying the square root of 16
            Console.WriteLine(Math.Pow(2, 3)); // Displaying 2 raised to the power of 3
            Console.WriteLine(Math.Abs(-10)); // Displaying the absolute value of -10
            Console.WriteLine(Math.Max(5, 10)); // Displaying the maximum of two numbers
            Console.WriteLine(Math.Min(5, 10)); // Displaying the minimum of two numbers
            Console.WriteLine(Math.Round(3.14159)); // Displaying the rounded value of Pi
            Console.WriteLine(Math.Ceiling(3.14)); // Displaying the smallest integer greater than or equal to 3.14
            Console.WriteLine(Math.Floor(3.99)); // Displaying the largest integer less than or equal to 3.99
        }
    }
}