﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(ListNode next)
        {
            this.next = next;
        }
    }
}