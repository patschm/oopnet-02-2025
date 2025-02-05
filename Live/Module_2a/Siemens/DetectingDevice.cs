using IEEE;

namespace Siemens;

public delegate void DeviceAction();

public class DetectingDevice
{
    private List<IDevice> devices = new List<IDevice>();
    private DeviceAction actions;
    public event Action Detecting;

    public void Connect(DeviceAction device)
    {
        actions += device;
    }
    public void Connect(IDevice device)
    {
        devices.Add(device);
    }

    public void Detect()
    {
        Console.WriteLine("We're detecting something...");
        actions();
        Detecting();
        foreach(IDevice device in devices)
        {
            device.Signal();
        }
    }
}
