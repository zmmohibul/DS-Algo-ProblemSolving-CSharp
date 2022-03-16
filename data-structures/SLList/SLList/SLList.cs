namespace SLList
{
    public class SLList
    {
        private class IntNode
        {
            public int Item { get; set; }
            public IntNode Next { get; set; }

            public IntNode(int item, IntNode next)
            {
                Item = item;
                Next = next;
            }
        }

        private IntNode Sentinal { get; set; }
        public int Length { get; set; }

        public SLList()
        {
            Sentinal = new IntNode(11, null);
            Length = 0;
        }

        public SLList(int x)
        {
            Sentinal = new IntNode(11, null);
            Sentinal.Next = new IntNode(x, null);
            Length += 1;
        }

        public void AddFirst(int x)
        {
            var n = new IntNode(x, Sentinal.Next);
            Sentinal.Next = n;
            Length += 1;
        }

        public int GetFirst()
        {
            return Sentinal.Next.Item;
        }

        public void AddLast(int x)
        {
            var lastNode = GetLastNode(Sentinal.Next);
            lastNode.Next = new IntNode(x, null);
            Length += 1;
        }
        
        private IntNode GetLastNode(IntNode P)
        {
            if (P.Next == null)
            {
                return P;
            }
            else
            {
                return GetLastNode(P.Next);
            }
        }

        public int GetLast()
        {
            var lastNode = GetLastNode(Sentinal.Next);
            return lastNode.Item;
        }

        public int GetLengthRecursively()
        {
            return GetLengthRecursively(Sentinal.Next);
        }

        private int GetLengthRecursively(IntNode P)
        {
            if (P.Next == null)
            {
                return 1;
            }

            return 1 + GetLengthRecursively(P.Next);
        }

        public void SquareAndInsert(int x) 
        {
            IntNode last = SquareAndInsert(this.Sentinal.Next);
            IntNode n = new IntNode(x, null);
            last.Next = n;
        }

        private IntNode SquareAndInsert(IntNode p) {
            if (p.Next == null) {
                IntNode n = new IntNode(p.Item * p.Item, null);
                p.Next = n;
                return p.Next;
            }

            IntNode n1 = new IntNode(p.Item * p.Item, p.Next);
            p.Next = n1;
            return SquareAndInsert(n1.Next);
        }

        public void PrintList() 
        {
            for (IntNode p = Sentinal.Next; p != null; p = p.Next) {
                System.Console.WriteLine(p.Item + " ");
            }
            System.Console.WriteLine();
        }
    }
}