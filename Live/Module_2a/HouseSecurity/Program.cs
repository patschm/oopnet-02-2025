using DoomsdayPreppers;
using Heras;
using Logitech;
using Siemens;

namespace HouseSecurity;

internal class Program
{
    static void Main()
    {
        DetectingDevice detDev = new DetectingDevice();
        Fence fence = new Fence();
        Camera camera = new Camera();
        Pitfall pitfall = new Pitfall();


        detDev.Connect(camera);
        detDev.Connect(pitfall);
        detDev.Connect(fence);

        detDev.Detect();
        
    }
}
