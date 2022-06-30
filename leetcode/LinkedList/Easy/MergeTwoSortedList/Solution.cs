using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MergeTwoSortedList
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
        {
            if (list1 == null && list2 != null)
            {
                return list2;
            }

            if (list1 != null && list2 == null)
            {
                return list1;
            }

            if (list1 == null && list2 == null)
            {
                return list2;
            }

            ListNode head = null;
            ListNode currHead = head;
            var currList1 = list1;
            var currList2 = list2;

            while (currList1 != null && currList2 != null)
            {
                ListNode node;
                if (currList1.val == currList2.val)
                {
                    node = new ListNode(currList1.val);
                    node.next = new ListNode(currList1.val);
                    currList1 = currList1.next;
                    currList2 = currList2.next;
                }
                else if (currList1.val < currList2.val)
                {
                    node = new ListNode(currList1.val);
                    currList1 = currList1.next;
                }
                else
                {
                    node = new ListNode(currList2.val);
                    currList2 = currList2.next;
                }


                if (head == null)
                {
                    head = node;
                    currHead = node;
                    if (head.next != null)
                    {
                        currHead = head.next;
                    }
                }
                else
                {
                    currHead.next = node;
                    currHead = currHead.next;
                    if (currHead.next != null)
                    {
                        currHead = currHead.next;
                    }
                }

            }

            if (currList1 != null)
            {
                currHead.next = currList1;
            }

            if (currList2 != null)
            {
                currHead.next = currList2;
            }

            return head;
        }
    }
}