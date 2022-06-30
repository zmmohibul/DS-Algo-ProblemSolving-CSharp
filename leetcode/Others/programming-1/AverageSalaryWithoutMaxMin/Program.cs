double Average(int[] salary) {
    double average = 0;
    int maxSalary = int.MinValue;
    int minSalary = int.MaxValue;

    var salaryLength = salary.Length;
    if (salaryLength <= 2) {
        return 0;
    }

    for (int i = 0; i < salaryLength; i++) {
        var s = salary[i];
        average += s;

        if (s > maxSalary) {
            maxSalary = s;
        }

        if (s < minSalary) {
            minSalary = s;
        }
    }

    average -= maxSalary;
    average -= minSalary;
    average = average / (salaryLength - 2);

    return average;
        
}