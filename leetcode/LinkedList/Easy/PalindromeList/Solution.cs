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
            var curr = head;
            var totalItem = 0;
            while (curr != null)
            {
                totalItem += 1;
                curr = curr.next;
            }

            curr = head;
            var rev = new int[totalItem];
            var i = totalItem - 1;
            while (curr != null)
            {
                rev[i] = curr.val;
                curr = curr.next;
                i -= 1;
            }

            curr = head;
            i = 0;
            while (curr != null)
            {
                if (rev[i] != curr.val)
                {
                    return false;
                }
                curr = curr.next;
                i += 1;
            }

            return true;
        }
    }
}