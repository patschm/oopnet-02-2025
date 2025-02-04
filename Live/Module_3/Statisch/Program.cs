namespace Statisch;

internal class Program
{
    int counter = 0;

    static void Main(string[] args)
    {
        Console.WriteLine(counter);
        Floor[] building = new Floor[37];
        for (int i = 0; i < building.Length; i++)
        {
            building[i] = new Floor { Number = i };
        }

        building[15].CallElevator();
        //Floor.CallElevator();

        foreach (Floor floor in building)
        {
            floor.ShowElevatorStatus();
        }
    }
}
