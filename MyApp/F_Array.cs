using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class F_Array
    {
        public static void ShowArray(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            // Console.WriteLine(arr[1]);

            // Display another way to create and display an array
            string[] name = new string[5];
            name[0] = "Dilip";
            name[1] = "Patel";
            name[2] = "C#";
            name[3] = "Programming";
            name[4] = "Tutorial";

            // Console.WriteLine(name[0]);
            // Console.WriteLine(name[1]);
            // Console.WriteLine(name[2]);
            // Console.WriteLine(name[3]);
            // Console.WriteLine(name[4]);

            // Display array using loop
            foreach (string i in name)
            {
                // Console.WriteLine(i);
            }


            // Another way to create and display an array
            int[] arr1 = new int[5];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;
            arr1[3] = 40;
            arr1[4] = 50;

            // Display array using loop
            for (int i = 0; i < arr1.Length; i++)
            {
                // Console.WriteLine(arr1[i]);
            }

            // or we can write 'for' look like this too
            foreach (int i in arr1)
            {
                // Console.WriteLine(i);
            }


            // 2D array example
            int[,] arr2D = {
                {3,4},
                {5,6},
                {8,9}
            };
            Console.WriteLine(arr2D[0, 1]); // Accessing element at row 0, column 1
        }
    }
}