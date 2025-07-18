using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class M_Object
    {
        public int age(int age)
        {
            if (age < 18)
            {
                return 0; // Not an adult
            }
            else
            {
                return 1; // Adult
            }
        }
    }
}