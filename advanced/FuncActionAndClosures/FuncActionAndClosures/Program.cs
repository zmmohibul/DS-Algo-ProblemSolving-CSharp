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
/*
 * So Actions are Pre-Defined Delegates that takes in parameters but return type is void
 */







void MeasureTimeTakingFuncAsParam(Func<int> func)
{
    var stopwatch = Stopwatch.StartNew();
    var result = func();
    result -= 1000;
    Console.WriteLine($"Inside MeasureTimeTakingFuncAsParam, value of the result is: {result}");
}

int FuncFunction()
{
    var n = 2;
    for (int i = 0; i < 100000000; i++)
    {
        n += 1;
    }

    return n;
}

MeasureTimeTakingFuncAsParam(FuncFunction);



void MeasureTimeTakingFuncAsParam2(Func<int, int> func)
{
    var stopwatch = Stopwatch.StartNew();
    var result = func(3);
    result -= 1000;
    Console.WriteLine($"Inside MeasureTimeTakingFuncAsParam2, value of the result is: {result}");
}

MeasureTimeTakingFuncAsParam2(int (n) =>
{
    for (int i = 0; i < 100000000; i++)
    {
        n += 1;
    }
    
    Console.WriteLine($"Inside the Func of MeasureTimeTakingFuncAsParam2, value of the n is: {n}");

    return n;
});
/*
 * So Funcs are Pre-Defined Delegates that takes in parameters and has a return type
 */
