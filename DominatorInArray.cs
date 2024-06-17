using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class DominatorInArray
    {
        /*
         int[]arr1 = { 3, 4, 3, 2, 3, -1, 3, 3 };
        int[]arr2 = { 3, 3, 3, 3, 2, 2, 2 };
        int result = DominatorInArray.Solution(arr2);
        Console.WriteLine(result);
         */
        public static int Solution(int[] A) 
        {
            // 初始化一个字典，用于存储数组元素及其出现次数
            Dictionary<int, int> dic = new Dictionary<int, int>();

            // 计算数组长度的一半，用于判断元素是否超过半数
            int half = A.Length;
            half /= 2;

            // 特殊情况处理：如果数组长度为1，直接返回0
            if (A.Length == 1)
            {
                return -1;
            }

            // 遍历数组
            for (int i = 0; i < A.Length; i++)
            {
                // 如果当前元素已在字典中，则增加其计数
                if (dic.ContainsKey(A[i]))
                {
                    dic[A[i]] = dic[A[i]] + 1;

                    // 检查当前元素计数是否超过数组长度的一半
                    if (dic[A[i]] > half)
                    {
                        // 是，则返回当前元素的索引
                        return i;
                    }
                }
                else
                {
                    // 如果当前元素不在字典中，将其添加并初始化计数为1
                    dic.Add(A[i], 1);
                }
            }

            // 遍历结束，未找到满足条件的元素，返回-1
            return -1;
        }
    }
}
