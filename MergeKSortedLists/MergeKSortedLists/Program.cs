using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeKSortedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListNode[] lists = new ListNode[3];
            lists[0] = new ListNode(1);
            lists[0].next = new ListNode(4);
            lists[0].next.next = new ListNode(5);
            lists[1] = new ListNode(1);
            lists[1].next = new ListNode(3);
            lists[1].next.next = new ListNode(4);
            lists[2] = new ListNode(2);
            lists[2].next = new ListNode(6);
            ListNode head = MergeKLists(lists);
        }
        public static ListNode MergeKLists(ListNode[] lists)
        {
            ListNode head = new ListNode(0);
            ListNode currency = head;
            int min_Index = -1;
            int min_Val = 0;
            while (true)
            {
                min_Index = -1;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (min_Index == -1 && lists[i] != null)
                    {
                        min_Val = lists[i].val;
                        min_Index = i;
                        continue;
                    }
                    if (lists[i] != null && min_Val > lists[i].val)
                    {
                        min_Val = lists[i].val;
                        min_Index = i;
                    }
                }
                if (min_Index == -1)
                {
                    break;
                }
                currency.next = new ListNode(lists[min_Index].val);
                currency = currency.next;
                lists[min_Index] = lists[min_Index].next;
            }
            return head.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }
}
