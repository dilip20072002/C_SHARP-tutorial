using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class N_Getter_Setter
    {
        public string name;
        public string address;
        private int age;

        public N_Getter_Setter(string aName, string newAddress, int newAge)
        {
            name = aName;
            address = newAddress;
            Age = newAge;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    Age = 0; // Ensure age is not negative
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}