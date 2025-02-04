using IEEE;

namespace Logitech;

public class Camera : IDevice
{
    public void Record()
    {
        Console.WriteLine("The camera records the onslaught");
    }

    public void Signal()
    {
        Record();
    }
}
