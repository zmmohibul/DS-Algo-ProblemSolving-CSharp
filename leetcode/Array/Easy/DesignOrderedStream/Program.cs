OrderedStream os = new OrderedStream(5);
os.Insert(3, "ccccc").ToList().ForEach(item => Console.Write($"-- {item}, "));
System.Console.WriteLine();

os.Insert(1, "aaaaa").ToList().ForEach(item => Console.Write($"-- {item}, "));
System.Console.WriteLine();

os.Insert(2, "bbbbb").ToList().ForEach(item => Console.Write($"-- {item}, "));
System.Console.WriteLine();

os.Insert(5, "eeeee").ToList().ForEach(item => Console.Write($"-- {item}, "));
System.Console.WriteLine();

os.Insert(4, "ddddd").ToList().ForEach(item => Console.Write($"-- {item}, "));
System.Console.WriteLine();


public class OrderedStream 
{
    private string[] arr;
    private int ptr = 0;

    public OrderedStream(int n) 
    {
        this.arr = new string[n];
    }
    
    public IList<string> Insert(int idKey, string value) 
    {
        arr[idKey - 1] = value;
        
        var listToReturn = new List<string>();

        if (idKey - 1 == ptr)
        {
            var tempPtr = ptr;
            while (tempPtr < arr.Length)
            {
                listToReturn.Add(arr[tempPtr]);
                tempPtr += 1;
                if (tempPtr >= arr.Length || arr[tempPtr] == null)
                {
                    break;
                }
            }
        }

        ptr += listToReturn.Count;
        return listToReturn;
    }
}