namespace InteractionIssues;

internal class Shengyu:Employee
{
    public void ComesInTime()
    {
        Console.WriteLine("Shengyu comes in time to produce things");
    }
    public override void DoWork()
    {
        ComesInTime();
    }
}
