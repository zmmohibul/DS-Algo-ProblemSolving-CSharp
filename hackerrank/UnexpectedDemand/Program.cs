System.Console.WriteLine(filledOrders(new List<int>{10, 30}, 40));

System.Console.WriteLine(filledOrders(new List<int>{8526325, 4867889, 8459224, 3142131, 9022648, 4681201, 3069980, 7567872, 8928157, 4199985, 3978583, 8896023, 9897954, 3337377, 60730, 6728438, 6560134, 7127216, 4662643, 6798622, 4460887, 6785305, 2658899, 5800236, 5519679, 3179685,}, 225500280));

int filledOrders(List<int> order, int k)
{
    int answer = 0;

    order.Sort();

    foreach (var o in order) 
    {
        System.Console.Write($"{o}, ");
        if (o <= k)
        {
            answer += 1;
            k -= o;
        }
    }
    System.Console.WriteLine();

    return answer;  

}