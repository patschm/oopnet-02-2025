namespace InteractionIssues;

internal class Bokito : IContract
{
    public void DoWork()
    {
        Console.WriteLine("Bokito harrassing woman");
    }

    public void Work()
    {
        DoWork();
    }
}
