using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeList
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode revListHead = null;
            var curr = head;
            while (curr != null)
            {
                if (revListHead == null)
                {
                    revListHead = new ListNode(curr.val, null);
                }
                else
                {
                    var newNode = new ListNode(curr.val, revListHead);
                    revListHead = newNode;
                }
                curr = curr.next;
            }

            curr = head;
            var revCurr = revListHead;
            while (curr != null)
            {
                if (curr.val != revCurr.val)
                {
                    return false;
                }
                curr = curr.next;
                revCurr = revCurr.next;
            }

            return true;
        }
    }
}