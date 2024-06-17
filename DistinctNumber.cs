using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class DistinctNumber
    {
        /*
         int[] arr1 = { 2, 1, 1, 5, 2, 3, 1, 4, 4, -12, -12, -6 };
         int[] arr2 = { 1, 2, 2, 2 };
         int[] arr3 = { 2, 2, 2, 2 };
         int result = DistinctNumber.Solution(arr3);
         Console.WriteLine(result);
         */
        public static int Solution(int[] A)
        {
            int diff = 1;
            Array.Sort(A);

            for (int i = 0;i < A.Length - 1;i++)
            {   
                if (A[i] != A[i+1])
                {
                    diff++;
                }
            }

            return diff;
        }
    }
}
