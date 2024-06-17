using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class NestedString
    {
        /*
        String s1 = "{[()()]}";
        String s2 = "([)()]";
        int result = NestedString.Solution(s2);
        Console.WriteLine(result);
         */

        // 栈是先进后出/后进先出
        public static int Solution(String s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    if (c == ')')
                    {
                        if (stack.Pop() != '(')
                            return 0;
                    }
                    if (c == ']')
                    {
                        if (stack.Pop() != '[')
                            return 0;
                    }
                    if (c == '}')
                    {
                        if (stack.Pop() != '{')
                            return 0;
                    }
                }
                else
                {
                    return 0;
                }
                // Console.WriteLine(c);
            }
            if (stack.Count == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
            public static int WrongSolution(String s)
        {
            int isNested = 0;

            if (!String.IsNullOrEmpty(s)) 
            {
                if (s.Length > 0 && s.Length % 2 == 0) 
                {
                    for (int i = 0; i < s.Length/2; i++)
                    {
                        // Console.WriteLine("Index: " + i + " : " +s[i]);
                        if (s[i] == s[s.Length -1 - i]) 
                        {
                            Console.WriteLine("Index: " + i + " : " + s[i]);
                            isNested = 1;
                        }
                    }
                }
            }

            return isNested;
        }
    }
}
