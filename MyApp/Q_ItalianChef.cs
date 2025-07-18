using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class Q_ItalianChef : P_Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Pasta is ready!");
        }

        public override void MakeSpecialDish()  // Overriding the virtual method from P_Chef
        {
            Console.WriteLine("Special Dish is ready!");
        }
    }
}