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
        }

        public int GetFirst()
        {
            return Sentinal.Next.Item;
        }
    }
}