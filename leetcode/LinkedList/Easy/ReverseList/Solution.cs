namespace ReverseList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode newHead = null;
            var curr = head;
            while (curr != null)
            {
                if (newHead == null)
                {
                    newHead = new ListNode(curr.val, null);
                }
                else
                {
                    var node = new ListNode(curr.val, newHead);
                    newHead = node;
                }

                curr = curr.next;
            }


            return newHead;
        }
    }
}