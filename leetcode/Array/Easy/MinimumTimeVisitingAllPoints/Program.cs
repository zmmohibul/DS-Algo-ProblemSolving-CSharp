var list = new List<List<int>>();
list.Add(new List<int>{1, 1});
list.Add(new List<int>{3, 4});
list.Add(new List<int>{-1, 0});

// var points = new int[3][2];

// points[0] = new int[] {1, 1};
// points[1] = new int[] {3, 4};
// points[2] = new int[] {-1, 0};
System.Console.WriteLine(MinTimeToVisitAllPoints(list));



int MinTimeToVisitAllPoints(List<List<int>> points) 
{
    var point1 = points[0];
    var time = 0;
    for (int i = 1; i < points.Count; i++)
    {
        var point2 = points[i];



        while (point1[0] != point2[0] || point1[1] != point2[1])
        {
            if (point2[0] > point1[0] && point2[1] > point1[1])
            {
                point1[0] += 1;
                point1[1] += 1;
                time += 1;
                continue;
            }

            if (point2[0] > point1[0])
            {
                point1[0] += 1;
                time += 1;
            }

            if (point2[1] > point1[1])
            {
                point1[1] += 1;
                time += 1;
            }


            if (point2[0] < point1[0] && point2[1] < point1[1])
            {
                point1[0] -= 1;
                point1[1] -= 1;
                time += 1;
                continue;
            }

            if (point2[0] < point1[0])
            {
                point1[0] -= 1;
                time += 1;
            }

            if (point2[1] < point1[1])
            {
                point1[1] -= 1;
                time += 1;
            }
        }

        point1 = point2;
    }

    return time;
}