int MaximumWealth(int[][] accounts) {
    var maxWealth = 0;
    var currentCustomerWealth = 0;

    foreach (var customerAccount in accounts)
    {
        foreach (var amount in customerAccount) 
        {
            currentCustomerWealth += amount;
        }

        if (maxWealth < currentCustomerWealth) 
        {
            maxWealth = currentCustomerWealth;
        }

        currentCustomerWealth = 0;
    }


    return maxWealth;
}