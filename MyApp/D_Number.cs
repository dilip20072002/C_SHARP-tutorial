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
        }
    }
}