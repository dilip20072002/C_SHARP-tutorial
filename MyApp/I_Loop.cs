using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApp
{
    class I_Loop
    {
        public static void ShowLoop(string[] args)
        {
            // For loop example
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                // Console.WriteLine(arr[i]);
            }

            // While loop example
            int j = 0;
            while (j < arr.Length)
            {
                // Console.WriteLine(arr[j]);
                j++;
            }

            // Do-while loop example
            int k = 0;
            do
            {
                // Console.WriteLine(arr[k]);    // This will first print then check the condition
                k++;
            } while (k < arr.Length);

            // Foreach loop example
            foreach (int item in arr)
            {
                // Console.WriteLine(item);
            }

            // Nested loop example
            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 2; n++)
                {
                    // Console.WriteLine($"Outer: {m}, Inner: {n}");
                }
            }

            // Break and continue example
            for (int x = 0; x < 5; x++)
            {
                if (x == 2)
                {
                    // Console.WriteLine("Skipping 2");
                    continue; // Skip the rest of the loop when l is 2
                }
                if (x == 4)
                {
                    // Console.WriteLine("Breaking at 4");
                    break; // Exit the loop when l is 4
                }
                // Console.WriteLine(x);
            }



            // 'Guessing the City Name' game example
            string secret = "Kolkata";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secret && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Guess the city name:");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
        }
    }
}