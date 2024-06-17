using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class RealOA
    {
        // 找数组中的最小元素
        public static int Solution1(int[] A)
        {
            int ans = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < ans)
                {
                    ans = A[i];
                }
            }
            return ans;
        }

        public static int Solution2(int[] A)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                int product = 1;

                for (int j = 0; j < A.Length; j++)
                {
                    if (i != j)
                    {
                        product *= A[j];
                    }
                }
                hs.Add(product);
            }

            return hs.Count;
        }

        public static string Solution3(string S) 
        {

            return S;
        }
    }
}