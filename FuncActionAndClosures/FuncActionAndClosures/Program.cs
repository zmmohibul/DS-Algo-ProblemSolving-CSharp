using System.Diagnostics;

var watch = Stopwatch.StartNew();
CountToInfinity();
watch.Stop();
Console.WriteLine(watch.Elapsed);

void CountToInfinity()
{
    for (var i = 0; i < 1000000000; i++) ;
}

MeasureTimeTakingActionAsParam(CountToInfinity);
MeasureTimeTakingActionAsParam(() =>
{
    for (int i = 0; i < 1000000000; i++) ;
});

void MeasureTimeTakingActionAsParam(Action action)
{
    var watch = Stopwatch.StartNew();
    action();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
}









void SomeFunction(int n)
{
    for (int i = 0; i < 1000000000; i++)
    {
        n += 1;
    }

    Console.WriteLine($"Inside SomeFunction Action, value of n after calculation: {n}");
}

void MeasureTimeTakingActionAsParam2(Action<int> action)
{
    var watch = Stopwatch.StartNew();
    action(10);
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
}

MeasureTimeTakingActionAsParam2(SomeFunction);
MeasureTimeTakingActionAsParam2((int n) =>
{
    for (int i = 0; i < 1000000000; i++)
    {
        n -= 1;
    }

    Console.WriteLine($"Inside Anonymous delegate that is used as Action, value of n after calculation: {n}");
});



