using System;

namespace RandomPermutation
{
   class Program
   {
      static int LIMIT = 20; // You can manipulate this size if you want to
      static void Main(string[] args) // the Main method
      {
         int[] Permutation = new int[LIMIT]; // Creation of array Permutation[0..LIMIT-1]

         Console.Write("Initial Permutation is ["); // Initialisation of Permutation[0..LIMIT-1]
         for (int i = 0; i < LIMIT; ++i)
         {
            Permutation[i] = i + 1;
            Console.Write(Permutation[i]);
            if (i + 1 < LIMIT) Console.Write(",");
         }
         Console.WriteLine("]");

         RPermute(LIMIT, ref Permutation); // You are asked to implement this method recursively, see the pseudocode

         Console.Write("Random Permutation is ["); // Final printout of elemnts in Permutation[0..LIMIT-1]
         for (int i = 0; i < LIMIT; ++i)
         {
            Console.Write(Permutation[i]);
            if (i + 1 < LIMIT) Console.Write(",");
         }
         Console.WriteLine("]");

      }
      static void RPermute(int n, ref int[] Array)
      {
         //If(n > 1)r = random number from the range[0, n - 2]; Swap contents of Permutation[n - 1]and Permutations[r]RPermute(n - 1, Permutation)//
         if (n > 1)
         {
            Random random = new Random();
            int r = random.Next(0, n - 2);
            Swap(n - 1, r, ref Array);
            RPermute(n - 1, ref Array);

         }
         // IT DOES NOTHING FOR NOW - you are asked to implement this method
      }

      static void Swap(int i, int j, ref int[] Array) // Swap method, feel free to use it
      {
         int temp = Array[i];
         Array[i] = Array[j];
         Array[i] = Array[j];
         Array[j] = temp;
      }
   }
}
