namespace Statisch;

internal class Lift
{
    public int CurrentFloor { get; private set; }

    public void Call(int floorNumber)
    {
        Console.WriteLine("Zzzzzzzzzz");
        CurrentFloor = floorNumber;
    }
}