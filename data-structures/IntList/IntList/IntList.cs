namespace IntList
{
    public class IntList
    {
        public int First { get; set; }
        public IntList Rest { get; set; }

        public IntList()
        {
        }

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

        public int Get(int i)
        {
            if (i == 0)
            {
                return First;
            }

            return Rest.Get(i - 1);  
        }

        public static IntList IncrList(IntList L, int x)
        {
            var listToReturn = new IntList();
            IntList.CopyList(L, listToReturn);
            listToReturn.IncrementList(x);
            return listToReturn;
        }

        private void IncrementList(int x)
        {
            if (Rest == null)
            {
                return;
            }

            First += 3;
            Rest.IncrementList(x);
        }

        public static IntList CopyList(IntList ListToCopyFrom, IntList ListToCopyTo)
        {
            if (ListToCopyFrom.Rest == null)
            {
                return ListToCopyTo;
            }
            ListToCopyTo.First = ListToCopyFrom.First;
            ListToCopyTo.Rest = new IntList();
            return IntList.CopyList(ListToCopyFrom.Rest, ListToCopyTo.Rest);
        }

        public static IntList DecrList(IntList L, int x)
        {
            L.DecrementList(x);
            return L;
        }

        public void DecrementList(int x)
        {
            if (Rest == null)
            {
                First -= x;
                return;
            }

            First -= x;
            Rest.DecrementList(x);
        }
    }
}