using System;

namespace ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            //assigning the 10 array indexes with i++ values, so 0, 1, 2, ... 10

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 10;
            }
            /*
           for (int j = 0; j < 10; j++)
           {
               // Element {j} -> the index // {numbers[j]} -> the index value
               Console.WriteLine($"Element {j} = {numbers[j]}");
           }
           */

            int counter = 0;
            //create a variable int called "k" and run thru the whole array "numbers"
            // "k" is the value of "numbers" at a specific index
            foreach (int k in numbers) 
            {
                Console.WriteLine($"Element {counter++} = {k}");
            }

            Console.Read();
        }
    }
}
