using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    // 找到一个数组中缺失的第一个正数
    /*
        int[] A = { 33, -21, 331, 21, 102 };
        int data = FindSmallestPositiveNumber.HashSolution2(A);
     */
    internal class FindSmallestPositiveNumber
    {
        public static int Solution(int[] A)
        {
            List<int> pos = new List<int>();
            foreach (int num in A)
            {
                if (num >= 1)
                {
                    pos.Add(num);
                }
            }

            pos.Sort();
            int x = 1;

            for (int i = 0; i < pos.Count; i++)
            {
                if (x < pos[i])
                {
                    return x;
                }
                x = pos[i] + 1;
            }

            return x;
        }

        // 有问题，如果数组中有负数，则返回的是负数。放弃
        public static int BadSolution(int[] A)
        {
            int maxValue = A.Max();
            Array.Sort(A);

            int x = 1;

            if (maxValue > 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (x < A[i])
                    {
                        if (A[i] > 0)
                        {
                            return x;
                        }
                    }
                    x = A[i] + 1;
                }
                return x;
            }
            else if (maxValue < 0)
            {
                maxValue = 1;
            }
            return maxValue;
        }

        public static int HashSolution(int[] A)
        {
            HashSet<int> hs = new HashSet<int>(A);
            int i = 1;

            while (hs.Contains(i))
            {
                i++;
            }
            return i;
        }

        public static int HashSolution2(int[] A)
        {
            HashSet<int> hs = new HashSet<int>(A);
            for (int i = 1; true; i++)
            {
                if (!hs.Contains(i))
                {
                    return i;
                }
            }
        }
    }
}
