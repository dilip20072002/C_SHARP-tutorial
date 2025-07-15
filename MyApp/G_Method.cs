using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class G_Method
    {
        // public static void ShowMethod(string[] args)
        // {
        //     intro("Dilip");
        // }
        // static void intro(string name)
        // {
        // Console.WriteLine("Hello from new repo, " + name);
        // }



        //Return statement -
        public static void ShowMethod(string[] args)
        {
            Console.WriteLine(cal(32));
        }
        static int cal(int value)
        {
            int result = value * 2;
            return result;
        }
    }
}