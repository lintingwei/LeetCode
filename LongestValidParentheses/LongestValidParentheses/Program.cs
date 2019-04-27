using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestValidParentheses
{
    public class Program
    {
        private const char LEFT_PARENTHESES = '(';
        private const char RIGHT_PARENTHESES = ')';

        public static void Main(string[] args)
        {
            string target = "()(())";
            int result = LongestValidParentheses(target);
        }
        public static int LongestValidParentheses(string s)
        {
            char[] target = s.ToCharArray();
            int max_Length_Right_Order = GetMaxValidLengthByOrdered(target, LEFT_PARENTHESES);
            int max_Length_Left_Order = GetMaxValidLengthByOrdered(target.Reverse().ToArray(), RIGHT_PARENTHESES);
            
            return Math.Max(max_Length_Right_Order, max_Length_Left_Order);
        }
        public static int GetMaxValidLengthByOrdered(char[] target, char determine_Char)
        {
            int length = 0;
            int max_Length = 0;
            int current = 0;

            for (int i = 0; i < target.Length; i++)
            {
                if (target[i].Equals(determine_Char))
                {
                    current++;
                }
                else
                {
                    current--;
                }

                if (current < 0)
                {
                    length = 0;
                    current = 0;
                }
                else if (current > 0)
                {
                    length++;
                }
                else
                {
                    length++;
                    max_Length = Math.Max(length, max_Length);
                }
            }
            return max_Length;
        }
    }
}
