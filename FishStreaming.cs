using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class FishStreaming
    {
        /*
         int[] A1 = { 4, 3, 2, 1, 5 };
         int[] A2 = { 4, 3, 5, 2, 1 };
         int[] B = { 0, 1, 0, 0, 0 };
         int result = FishStreaming.Solution(A2, B);
         Console.WriteLine(result);
         */
        public static int Solution(int[]A, int[]B)
        {
            int liveFish = A.Length;

            if (A.Length == 0)
            {
                return 0;
            }

            Stack<int> fishST = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                // Push downstream fish to stack
                if (B[i] == 1)
                {
                    fishST.Push(A[i]);
                }
                if (B[i] == 0)
                {
                    while (fishST.Count != 0)
                    {
                        // If the downstream fish is bigger than upstream fish, then upstream will be eaten.
                        if (fishST.Peek() > A[i])
                        {
                            liveFish--;
                            break; // the upstream fish is eaten, ending.
                        }
                        // If the downstream fish is smaller than upstream fish, then downstream will be eaten.
                        else if (fishST.Peek() < A[i]) 
                        {
                            liveFish--;
                            fishST.Pop(); // the downstream fish is eaten, not ending.
                        }
                    }
                }
            }

            return liveFish;
        }
    }
}
