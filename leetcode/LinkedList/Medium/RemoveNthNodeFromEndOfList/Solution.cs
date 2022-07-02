using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) 
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            var curr = head;
            var count = 0;
            while (curr != null)
            {
                count += 1;
                curr = curr.next;
            }

            var nIndex = count - n;
            curr = head;
            for (int i = 1; i < nIndex; i++)
            {
                curr = curr.next;
            }

            if (curr == head && nIndex == 1)
            {
                return curr.next;
            }
            else if (curr.next.next != null)
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr.next = null;
            }

            return head;
        }
    }
}