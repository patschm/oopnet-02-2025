namespace Statisch;

internal class Floor
{
    //private readonly Lift elevator;// = new Lift();
    private static Lift elevator = new Lift();
    public int Number { get; set; }

    //public Floor(Lift lft)
    //{
    //    elevator = lft;
    //}

    public void CallElevator()
    {
        elevator.Call( Number);
    }
    public void ShowElevatorStatus()
    {
        Console.WriteLine($"Where are you now? answer {elevator.CurrentFloor}");
    }
}
