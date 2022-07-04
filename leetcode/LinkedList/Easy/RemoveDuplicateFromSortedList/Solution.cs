using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoveDuplicateFromSortedList
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head) 
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            // 1 -> 2 -> 3
            //           c
            var curr = head;
            while (curr.next != null)
            {
                if (curr.val == curr.next.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }

            }
            return head;
        }
    }
}