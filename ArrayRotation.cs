using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class ArrayRotation
    {
        /*
            int []nums = { -1, -100, 3, 99 }; int k = 2;
            int []result = ArrayRotation.Solution(nums, k);
            foreach (int i in result) {
                Console.WriteLine(i);
            }
         */
        public static int[] Solution(int[] A, int k)
        {
            int size = A.Length;
            int[] newArray = new int[size];

            if (k < 0 || k > 100 || size == 0)
            {
                return newArray;
            }

            if (size == 1)
            {
                return A;
            }

            for (int i = 0; i < size; i++)
            {
                newArray[(i + k) % size] = A[i];
            }

            return newArray;
        }
    }
}
