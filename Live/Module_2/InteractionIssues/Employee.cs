namespace InteractionIssues;

internal class Employee : Person, IContract
{
    public virtual void DoWork()
    {
        Console.WriteLine("Someting");
    }

    public void Work()
    {
        DoWork();
    }
}
