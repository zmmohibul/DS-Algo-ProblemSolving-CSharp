System.Console.WriteLine(BusyStudent(new int[] {1,2,3}, new int[] {3,2,7}, 4));

int BusyStudent(int[] startTime, int[] endTime, int queryTime)
{
    int noOfStudents = 0;
    for (int i = 0; i < startTime.Length; i++)
    {
        if (startTime[i] <= queryTime && endTime[i] >= queryTime)
        {
            noOfStudents += 1;
        }
    }
    return noOfStudents;
}