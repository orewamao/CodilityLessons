using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class CountDivision
    {
        /*
                 var testCases = new (int x, int y, int d)[]
        {
             (6, 11, 2),
             (7 ,12, 5),
             (7, 12, 12),
             (1, 1, 11),
             (10, 10, 7),
        };

        foreach (var testCase in testCases)
        {
            int result = CountDivision.Solution(testCase.x, testCase.y, testCase.d);
            Console.WriteLine(result);
        }
         */
        public static int Solution(int A, int B, int K)
        {
            // 如果A本身就是K的倍数, 直接计算从A到B之间（含A和B）K的倍数的数量
            if (A % K == 0)
            {
                return (B - A) / K + 1;
            }
            // 如果A不是K的倍数，获得最接近（小于）A的K的倍数
            else
            {
                return (B - (A - A % K)) / K;
            }
        }

        /** 直接遍历了从A到B的所有数字来检查是否能被K整除，其时间复杂度是O(N)，其中N = B - A + 1。
         * 这意味着，当A和B之间的差距非常大时，如题目中给出的极端情况A = 0, B = 2,000,000,000，该方法会变得非常慢，因为它需要检查几乎20亿个数字。**/
        public static int BadSolution(int A, int B, int K)
        {
            int n = 0;

            // 优化版本
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    n++;
                }
            }

            //if (A < B) 
            //{
            //    for (int i = 0; i <= B - A; i++) {
            //        if ((A + i) % K == 0)
            //        {
            //            n++;
            //        }
            //    }
            //}
            //else if (A == B)
            //{
            //    return n;
            //}

            return n;
        }

    }


}
