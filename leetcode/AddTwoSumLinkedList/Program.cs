using System;

Console.WriteLine("Hello, World!");
ListNode n = new ListNode(1);
n.next = new ListNode(5);
n.next.next = new ListNode(8);
n.Print();

ListNode n2 = new ListNode(5);
n2.next = new ListNode(2);
n2.next.next = new ListNode(1);
n2.Print();

// ListNode r = AddTwoNumbers(n, n2);
// r.Print();

// AddTwoNumbers(new ListNode(), new ListNode());

ListNode sl = new ListNode(9);
System.Console.WriteLine(GetInt(sl));

ListNode sl2 = new ListNode(1);
sl2.next = new ListNode(9);
sl2.next.next = new ListNode(9);
sl2.next.next.next = new ListNode(9);
sl2.next.next.next.next = new ListNode(9);
sl2.next.next.next.next.next = new ListNode(9);
sl2.next.next.next.next.next.next = new ListNode(9);
sl2.next.next.next.next.next.next.next = new ListNode(9);
sl2.next.next.next.next.next.next.next.next = new ListNode(9);
sl2.next.next.next.next.next.next.next.next.next = new ListNode(9);
sl2.Print();
System.Console.WriteLine(GetInt(sl2));

ListNode r2 = AddTwoNumbers(sl, sl2);
r2.Print();

// sl.Print();


ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    long l1Int = GetInt(l1);
    long l2Int = GetInt(l2);

    long resultInt = l1Int + l2Int;

    List<int> resultIntReverseList = new List<int>();
    while (resultInt != 0) {
        int rem = (int) (resultInt % 10);
        resultIntReverseList.Add(rem);
        resultInt /= 10;
    }

    ListNode result = new ListNode();
    ListNode ptr = result;

    for (int i = 0; i < resultIntReverseList.Count; i++) {
        ptr.val = resultIntReverseList[i];
        if (i != resultIntReverseList.Count - 1) {
            ptr.next = new ListNode();
        }
        ptr = ptr.next;
    }

    return result;
}

long GetInt(ListNode l1) {
    List<int> l1List = new List<int>();
    for (ListNode node = l1; node != null; node = node.next) {
        l1List.Add(node.val);
    }

    long l1Int = 0;
    for (int i = l1List.Count - 1; i != -1; i--) {
        l1Int += l1List[i];
        if (i != 0) {
            l1Int *= 10;
        }
    }

    return l1Int;
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public void Print() {
        ListNode node;
        for (node = this; node.next != null; node = node.next) {
            Console.Write($"{node.val} -> ");
        }

        System.Console.Write($"{node.val}\n");
    }
}








