namespace IntList
{
    public class IntList
    {
        public int First { get; set; }
        public IntList Rest { get; set; }

        public IntList(int first, IntList rest)
        {
            First = first;
            Rest = rest;
        }

        public int Length()
        {
            if (Rest == null)
            {
                return 1;
            }

            return 1 + Rest.Length();
        }

        public int LengthIterative()
        {
            IntList p = this;
            int length = 0;
            while (p != null)
            {
                length += 1;
                p = p.Rest;
            }

            return length;
        }

        public int Get(int i)
        {
            if (i == 0)
            {
                return First;
            }

            return Rest.Get(i - 1);  
        }

        public int GetIterative(int i)
        {
            var p = this;
            for (int j = 0; j < i; j++)
            {
                p = p.Rest;
            }

            return p.First;
        }
    }
}