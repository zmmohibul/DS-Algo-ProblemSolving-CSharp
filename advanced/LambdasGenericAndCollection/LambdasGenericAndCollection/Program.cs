var products = new List<Product>
{
    new("Snickers", 70, "Chocolate", true),
    new("Assorted Seafood", 1470, "Pet Care", false),
    new("Pringles BBQ", 160, "Chips", true),
    new("Dan Cake Brownies", 130, "Cake", false),
    new("Mars", 70, "Chocolate", true),
    new("Dan Cake Chocolate Layer Cake", 130, "Cake", false),
    new("Category Less Product", 12345, string.Empty, false),
};
Console.WriteLine("\nAll Products:");
Console.WriteLine(string.Join(", ", products));



List<Product> FilterProductThatAreAvailable(List<Product> products)
{
    var productsToReturn = new List<Product>();
    foreach (var product in products)
    {
        if (product.Available)
        {
            productsToReturn.Add(product);
        }
    }

    return productsToReturn;
}

Console.WriteLine("\nProducts That Are Available:");
Console.WriteLine(string.Join(", ", FilterProductThatAreAvailable(products)));



List<Product> FilterProductWithNoCategory(List<Product> products)
{
    var productsToReturn = new List<Product>();
    foreach (var product in products)
    {
        if (string.IsNullOrEmpty(product.Category))
        {
            productsToReturn.Add(product);
        }
    }

    return productsToReturn;
}

Console.WriteLine("\nProducts That Have No Type:");
Console.WriteLine(string.Join(", ", FilterProductWithNoCategory(products)));



List<Product> FilterProductByCategory(List<Product> products, string category)
{
    var productsToReturn = new List<Product>();
    foreach (var product in products)
    {
        if (string.Equals(product.Category, category))
        {
            productsToReturn.Add(product);
        }
    }

    return productsToReturn;
}

Console.WriteLine("\nProducts That Have Type Chocolate:");
Console.WriteLine(string.Join(", ", FilterProductByCategory(products, "Chocolate")));

Console.WriteLine("\nProducts That Have Type Cake:");
Console.WriteLine(string.Join(", ", FilterProductByCategory(products, "Cake")));



List<Product> FilterProductUsingDelegate(List<Product> products, Filter filter)
{
    var productsToReturn = new List<Product>();
    foreach (var product in products)
    {
        if (filter(product))
        {
            productsToReturn.Add(product);
        }
    }

    return productsToReturn;
}

Console.WriteLine("\nProducts That Have Are Available (Delegate):");
Console.WriteLine(string.Join(", ", FilterProductUsingDelegate(products, (product) => product.Available)));



IEnumerable<Product> FilterProductUsingDelegateAndYield(IEnumerable<Product> products, Filter filter)
{
    foreach (var product in products)
    {
        if (filter(product))
        {
            yield return product;
        }
    }
}

Console.WriteLine("\nProducts That Have Are Available (Delegate & Yield):");
Console.WriteLine(string.Join(", ", FilterProductUsingDelegateAndYield(products, (product) => product.Available)));



IEnumerable<T> Filter<T>(IEnumerable<T> items, FilterGeneric<T> f)
{
    foreach (var item in items)
    {
        if (f(item))
        {
            yield return item;
        }
    }
}

Console.WriteLine("\nProducts That Have Are Available (Delegate, Yield & Generic):");
Console.WriteLine(string.Join(", ", Filter(products, (product) => product.Available)));

Console.WriteLine("\nProducts That Have Type Chocolate (Delegate, Yield & Generic):");
Console.WriteLine(string.Join(", ", Filter(products, (product) => string.Equals(product.Category, "Chocolate"))));



IEnumerable<T> FilterWithFunc<T>(IEnumerable<T> items, Func<T, bool> f)
{
    foreach (var item in items)
    {
        if (f(item))
        {
            yield return item;
        }
    }
}

Console.WriteLine("\nProducts That Have Are Available (Delegate, Yield, Generic & Func):");
Console.WriteLine(string.Join(", ", FilterWithFunc(products, (product) => product.Available)));

Console.WriteLine("\nProducts That Have Type Chocolate (Delegate, Yield, Generic & Func):");
Console.WriteLine(string.Join(", ", FilterWithFunc(products, (product) => string.Equals(product.Category, "Chocolate"))));


delegate bool Filter(Product product);
delegate bool FilterGeneric<T>(T item);
record Product(string Name, double Price, string Category, bool Available);
