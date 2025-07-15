using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class B_DataType
    {
        public static void ShowData()
        {
            int num = 43;
            string name = "Dilip Patel";
            bool isActive = true;
            char firstLetter = 'D';
            double pi = 3.14159;
            float price = 19.45f;
            float discount = price + 5.5f;

            Console.WriteLine("Number: " + num);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Is Active: {isActive}");
            Console.WriteLine($"First Letter: {firstLetter}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Discounted Price: {discount}");
        }    
    }

}
