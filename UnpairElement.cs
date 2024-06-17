using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class UnpairElement
    {
        public static int Solution(int[] A)
        {
            // Implement your solution here
            if (A.Length == 1)
            {
                return A[0];
            }

            Array.Sort(A);

            for (int i = 0; i < A.Length; i += 2)
            {
                if (i + 1 == A.Length)
                {
                    return A[i];
                }

                if (A[i] != A[i + 1])
                {
                    return A[i];
                }
            }

            return 0;
        }

        public static int BadSolution(int[] A)
        {
            // Implement your solution 
            int unpairElement = 0;
            bool found = false;

            Array.Sort(A);

            for (int i = 0; i < A.Length / 2; i += 2)
            {
                if (A[i] != A[i + 1])
                {
                    unpairElement = A[i];
                    found = true;
                }
            }
            if (found == false)
            {
                unpairElement = A.Last();
            }
            return unpairElement;

        }

    }
}
