using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianofTwoSortedArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };
            double result = FindMedianSortedArrays(nums1, nums2);
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
                int targetLength = nums1.Length + nums2.Length;
                int[] targetArray = new int[targetLength];
                int nums1Index = 0;
                int nums2Index = 0;
                int currency = 0;
                for (int i = 0; i < targetLength / 2 + 1 ; i++)
                {
                    if (nums1Index == nums1.Length)
                    {
                        currency = nums2[nums2Index++];
                    }
                    else if (nums2Index == nums2.Length)
                    {
                        currency = nums1[nums1Index++];
                    }
                    else if (nums1[nums1Index] < nums2[nums2Index])
                    {
                        currency = nums1[nums1Index++];
                    }
                    else
                    {
                        currency = nums2[nums2Index++];
                    }
                    targetArray[i] = currency;
                }
                double answer = 0;
                if (targetLength % 2 != 0)
                {
                    answer = targetArray[targetLength / 2];
                }
                else
                {
                    answer = (targetArray[targetLength / 2] + targetArray[(targetLength / 2) - 1]) / 2.0;
                }
                return answer;
        }
    }
}
