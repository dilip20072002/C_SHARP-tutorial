using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class J_Exception
    {
        public static void ShowException(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first num");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second num");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}