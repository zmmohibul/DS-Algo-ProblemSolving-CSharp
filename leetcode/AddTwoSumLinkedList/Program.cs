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

AddTwoNumbers(n, n2);


void AddTwoNumbers(ListNode l1, ListNode l2) {
    // reverse l1 (1 -> 5 -> 8) to get l1Reversed(8 -> 5 -> 1)
    
    // now l1Reversed has the number in right order 
    // take an integer l1Int 
    // traverse through l1Reversed and add the int to
    // l1Int then multiply by 10


    // repeat same process for l2

    // add l1Int & l2Int to get resultInt

    // make an list of resultInt



    // -------------------------
    // traverse through l1 and add each node's value to a List
    // List<int> l1List = new List<int>();
    // for (ListNode node = l1; node != null; node = node.next) {
    //     l1List.Add(node.val);
    // }

    // for (int i = l1List.Count - 1; i != -1; i--) {
    //     l1Int += l1List[i];
    //     if (i != 0) {
    //         l1Int *= 10;
    //     }
    // }

    int l1Int = GetInt(l1);
    int l2Int = GetInt(l2);


    System.Console.WriteLine(l1Int);
    System.Console.WriteLine(l2Int);

    



    // traverse the list in reverse and form l1Int by add List[i] and then multipl by 10

    // repeat same process for l2


    // add l1Int and l2Int to get resultInt
    int resultInt = l1Int + l2Int;
    System.Console.WriteLine(resultInt);

    // use mod and divide logic to form reverse resultIntReverseList

    List<int> resultIntReverseList = new List<int>();
    while (resultInt != 0) {
        resultIntReverseList.Add(resultInt % 10);
        resultInt /= 10;
    }

    foreach (var item in resultIntReverseList) {
        Console.Write($"{item}, ");
        
    }

    System.Console.WriteLine();


    // build the result to return from resultIntReverseList

    ListNode result = new ListNode();
    ListNode ptr = result;

    // foreach (var item in resultIntReverseList) {
    //     ptr.val = item;
    //     ptr.next = new ListNode();
    //     ptr = ptr.next;
    // }

    for (int i = 0; i < resultIntReverseList.Count; i++) {
        ptr.val = resultIntReverseList[i];
        if (i != resultIntReverseList.Count - 1) {
            ptr.next = new ListNode();
        }
        ptr = ptr.next;
    }

    result.Print();


    // return result;
}

int GetInt(ListNode l1) {
    List<int> l1List = new List<int>();
    for (ListNode node = l1; node != null; node = node.next) {
        l1List.Add(node.val);
    }

    int l1Int = 0;
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








