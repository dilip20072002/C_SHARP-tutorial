using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class P_Chef
    {
        public void MakeCHicken()
        {
            Console.WriteLine("Chicken is ready!");
        }

        public void MakeFish()
        {
            Console.WriteLine("Fish is ready!");
        }

        public virtual void MakeSpecialDish()    // Virtual method to be overridden
        {
            Console.WriteLine("Special Dish is ready!");
        }
    }
}