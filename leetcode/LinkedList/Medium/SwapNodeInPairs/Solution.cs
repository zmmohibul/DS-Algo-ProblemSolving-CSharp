using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapNodeInPairs
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head) 
        {
            if (head == null)
            {
                return head;
            }
            var curr = head.next;
            var prev = head;
            while (curr != null)
            {
                if (curr.next.next != null)
                {
                    var currNode1Next = curr.next;
                    var swapNode2Next = curr.next.next.next;
                    var currNext = curr.next;
                }
            }

            return head;
        }
    }
}