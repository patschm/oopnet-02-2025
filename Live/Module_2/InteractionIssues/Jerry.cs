namespace InteractionIssues;

internal class Jerry : Employee
{
    public void EatingDuringWork()
    {
        Console.WriteLine("Jerry eats while producing things");
    }
    public override void DoWork()
    {
        EatingDuringWork();
    }
}
