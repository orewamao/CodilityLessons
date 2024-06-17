using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class FrogJump
    {
        /*
         第一次100分。
        var testCases = new (int x, int y, int d)[]
        {
             (10, 85, 30),
             (10, 20, 2),
             (10, 10, 1),
        };

        foreach (var testCase in testCases) { 
            int result = FrogJump.Solution(testCase.x, testCase.y, testCase.d);
            Console.WriteLine(result);
        }
         */
        public static int Solution(int X, int Y, int D)
        {
            int count = 0;

            if (X < Y) 
            {
                if ((Y - X) % D == 0) {
                    count = (Y - X) / D;
                }
                else
                {
                    count = (Y - X) / D + 1;
                }
            }
            return count;
        }
    }
}
