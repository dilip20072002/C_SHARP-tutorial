using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class L_Constructor
    {
        public string name;
        
        // default constructor
        public L_Constructor()
        {
            name = "Default Name";
        }

        // parameterized constructor
        public L_Constructor(string x)
        {
            name = x;
        }
    }
}