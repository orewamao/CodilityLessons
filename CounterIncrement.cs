using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class CounterIncrement
    {
        public static int[] Solution(int N, int[] A)
        {
            // Implement your solution here
            int[] counter = new int[N];
            int maxCounter = 0; // 新增: 用来追踪当前的最大计数器值
            int maxUpdate = 0; // 新增: 用来追踪已知的最大更新值，用于减少重复计算

            for (int i = 0; i < A.Length; i++)
            {
                if (1 <= A[i] && A[i] <= N)
                {
                    // 更新计数器并同时更新maxCounter
                    if (counter[A[i] - 1] + 1 > maxCounter)
                    {
                        maxCounter = counter[A[i] - 1] + 1;
                    }
                    counter[A[i] - 1] = Math.Max(counter[A[i] - 1] + 1, maxUpdate); // 确保至少更新到已知的最大值
                }
                else if (A[i] == N + 1)
                {
                    // 只有当maxCounter大于maxUpdate时才需要更新所有计数器
                    if (maxCounter > maxUpdate)
                    {
                        maxUpdate = maxCounter; // 更新maxUpdate
                        for (int j = 0; j < counter.Length; j++)
                        {
                            counter[j] = maxUpdate;
                        }
                    }
                }
            }

            // 最后再检查一次，确保所有计数器至少更新到了maxUpdate
            for (int j = 0; j < counter.Length; j++)
            {
                counter[j] = Math.Max(counter[j], maxUpdate);
            }

            return counter;
        }

        public static int[] BadSolution(int N, int[] A)
        {
            // Implement your solution here
            int[] counter = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if (1 <= A[i] && A[i] <= N)
                {
                    counter[A[i] - 1] += 1;
                }
                if (A[i] == N + 1)
                {
                    int maxVal = counter.Max();
                    for (int j = 0; j < counter.Length; j++)
                    {
                        counter[j] = maxVal;
                    }
                }
            }
            return counter;
        }

    }
}
