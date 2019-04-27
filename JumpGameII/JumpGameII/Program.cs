using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpGameII
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 10,9,8,7,6,5,4,3,2,1,1,0 };
            int answer = Jump(nums);
            int answerII = BestSolution(nums);
        }
        public static int Jump(int[] nums)
        {
                int nowIndex = 0;
                int jumpCount = 0;
                while (nowIndex < nums.Length - 1)
                {
                    nowIndex = GetTheOptimalPosition(nowIndex, nums);
                    jumpCount++;
                }
                return jumpCount;
        }
        public static int GetTheOptimalPosition(int nowIndex, int[] target)
        {
            if (target[nowIndex] + nowIndex >= target.Length - 1)
            {
                return target.Length - 1;
            }
            int optimalPosition = 0;
            int maxMoveLength = 0;
            int distance = target[nowIndex];
            for (int i = 0; i < distance; i++)
            {
                nowIndex++;
                if (maxMoveLength <= target[nowIndex] + i)
                {
                    maxMoveLength = target[nowIndex] + i;
                    optimalPosition = nowIndex;
                }
            }
            return optimalPosition;
        }
        public static int BestSolution(int[] nums)
        {
            int jumpCount = 0;
            int nowIndex = 0;
            int max = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                max = Math.Max(max, i + nums[i]);
                if (max >= nums.Length - 1)
                {
                    jumpCount++;
                    break;
                }
                if (i == nowIndex)
                {
                    jumpCount++;
                    nowIndex = max;
                }
            }
            return jumpCount;
        }
    }
}
