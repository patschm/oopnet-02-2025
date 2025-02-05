namespace Dependencies;

internal class HostThingy : IHostThingy
{
    private readonly ICounter _counter;

    public HostThingy(ICounter counter)
    {
        _counter = counter;
    }
    public void Run()
    {
        _counter.Increment();
        _counter.Increment();
        _counter.Increment();
        _counter.Increment();
        Console.WriteLine(_counter.CounterValue);
    }
}
