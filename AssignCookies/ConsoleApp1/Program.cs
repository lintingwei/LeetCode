using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] g = {10,9,8,7 };
            int[] s = { 5,6,7,8 };
            QuickSort(g, 0, g.Length-1);
            QuickSort(s, 0, s.Length-1);
            for (int i = 0; i< g.Length;i++)
                Console.WriteLine(g[i]);
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
            Console.WriteLine(FindContentChildren(g,s));
        }
        public static int FindContentChildren(int[] g, int[] s)
        {
            int gCount = 0, sCount = 0, result = 0;
            while (gCount < g.Length && sCount < s.Length)
            {
                if (g[gCount] <= s[sCount]) {
                    gCount++;
                    sCount++;
                    result++;
                }
                else  {
                    sCount++;
                }
            }
            return result;
        }
        public static void QuickSort(int[] a,int l,int r) {
            int i = l;
            int j = r + 1;
            int privot;
            if (l < r) {
                privot = a[i];
                while (i < j)
                {
                    do
                    {
                        i++;
                    } while (i < j && a[i] < privot);
                    do
                    {
                        j--;
                    } while (a[j] > privot);
                    if (i < j)
                        Swap(a, i, j);
                }
                Swap(a, l, j);
                QuickSort(a, l, j-1);
                QuickSort(a, j + 1, r);
            }
            
        }
        public static void Swap(int[] a,int i,int j) {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
