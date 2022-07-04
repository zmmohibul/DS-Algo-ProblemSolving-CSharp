using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoveDuplicatedFromSortedListII
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head) 
        {
            if (head == null)
            {
                return null;
            }
            // 1 -> 2 -> 5
            //           c
            var numFreqInList = new Dictionary<int, int>();
            var curr = head;
            while (curr != null)
            {
                numFreqInList[curr.val] = numFreqInList.GetValueOrDefault(curr.val, 0) + 1;
                curr = curr.next;
            }

            curr = head;
            while (curr.next != null)
            {
                if (numFreqInList[curr.next.val] > 1)
                {
                    curr.next = curr.next.next;
                    continue;
                }
                curr = curr.next;
            }

            if (numFreqInList[head.val] > 1)
            {
                return head.next;
            }
            else
            {
                return head;
            }
        }
    }
}