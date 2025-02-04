using IEEE;

namespace Heras;

public class Fence : IDevice
{
    public void Open()
    {
        Console.WriteLine("The fence opens");
    }

    public void Signal()
    {
        Open();
    }
}
