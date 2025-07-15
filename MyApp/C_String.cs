using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class C_String
    {
        public static void ShowString(string[] args)
        {
            string name = "Dilip Patel";
            Console.WriteLine("First Line\nSecend Line");
            Console.WriteLine("First Line\"Secend Line");
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Contains("Dilip"));
            Console.WriteLine(name.StartsWith("Dilip"));
            Console.WriteLine(name.EndsWith("Patel"));
            Console.WriteLine(name.IndexOf('D'));
            Console.WriteLine(name.LastIndexOf('l'));
            Console.WriteLine(name.IndexOf("Patel"));
            Console.WriteLine(name.IndexOf("Dilip"));
            Console.WriteLine(name[4]);
            Console.WriteLine(name.Substring(0, 5));
            Console.WriteLine(name.Replace("Dilip", "Patel"));
            Console.WriteLine(name.Trim());
            Console.WriteLine($"Hello {name}, Welcome to C# Programming!");
        }
    }
}