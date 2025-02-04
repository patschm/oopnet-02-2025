using IEEE;

namespace Siemens;

public class DetectingDevice
{
    private List<IDevice> devices = new List<IDevice>();

    public void Connect(IDevice device)
    {
        devices.Add(device);
    }

    public void Detect()
    {
        Console.WriteLine("We're detecting something...");
        foreach(IDevice device in devices)
        {
            device.Signal();
        }
    }
}
