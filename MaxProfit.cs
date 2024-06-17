using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class MaxProfit
    {
        /*
        int[] dailyPrice1 = { 23171, 21011, 21123, 21366, 21013, 21367 };
        int result = MaxProfit.Solution(dailyPrice1);
        Console.WriteLine(result);
         */
        public static int Solution(int[] A)
        {
            int maxProfit = 0;
            int maxSlice = 0;

            for (int i = 1; i < A.Length; i++) {
                // 动态地追踪当前连续子序列所能达到的最大和
                maxProfit = Math.Max(0, maxProfit + (A[i] - A[i - 1]));
                // 记录这一过程中遇到的maxProfit的最大值，即全局最优解
                maxSlice = Math.Max(maxSlice, maxProfit);
            }

            if (maxSlice < 0) {
                maxSlice = 0;
            }
            return maxSlice;
        }

        //public static int SolutionB(int[] A)
        //{

        //    if (A.Length <= 1)
        //        return 0;

        //    int minPrice = A[0];
        //    int maxProfit = 0;

        //    for (int i = 1; i < A.Length; i++)
        //    {
        //        if (A[i] < minPrice)
        //            minPrice = A[i];
        //        else
        //        {
        //            int curProfit = A[i] - minPrice;
        //            if (curProfit > maxProfit)
        //                maxProfit = curProfit;
        //        }
        //    }
        //    return maxProfit;
        //}
    }
}
