using IEEE;

namespace DoomsdayPreppers;

public class Pitfall : IDevice
{
    public void Open()
    {
        Console.WriteLine("The pitfall opens and sharp spikes appear");
    }

    public void Signal()
    {
        Open();
    }
}
