var list = new List<List<int>>();
list.Add(new List<int>{1, 1});
list.Add(new List<int>{4, 3});
list.Add(new List<int>{-1, 0});

System.Console.WriteLine(MinTimeToVisitAllPoints(list));



int MinTimeToVisitAllPoints(List<List<int>> points) 
{
    var time = 0;
    var point1 = points[0];

    for (int i = 1; i < points.Count; i++)
    {
        var point2 = points[i];
        if (point2[0] >= point1[0] && point2[1] >= point1[1])
        {
            if (point2[0] < point2[1])
            {
                var dt = point2[0] - point1[0];
                time += dt;
                point1[0] += dt;
                point1[1] += dt;
                dt = point2[1] - point1[1];
                time += dt;
                point1[1] += dt;
            }
            else
            {
                var dt = point2[1] - point1[1];
                time += dt;
                point1[0] += dt;
                point1[1] += dt;
                dt = point2[0] - point1[0];
                time += dt;
                point1[0] += dt;
            }
        }
    }


    return time;
}

int GetMin(int n1, int n2)
{
    if (n1 < n2) 
    {
        return n1;
    }
    else 
    {
        return n2;
    }
}

int GetMax(int n1, int n2)
{
    if (n1 > n2) 
    {
        return n1;
    }
    else 
    {
        return n2;
    }
}