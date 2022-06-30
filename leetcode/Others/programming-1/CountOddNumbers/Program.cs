System.Console.WriteLine(CountOdds(1, 10));

int CountOdds(int low, int high) {
    int count = 0;
    
    for (int i = low; i <= high; i++) {
        if (i % 2 != 0) {
            count += 1;
        }
    }

    return count;
}

