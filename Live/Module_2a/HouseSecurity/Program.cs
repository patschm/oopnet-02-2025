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

        detDev.Detecting += camera.Record;
        detDev.Detecting += pitfall.Open;
        detDev.Detecting += fence.Open;
        
        detDev.Detecting += () => fence.Open();

        detDev.Connect(camera.Record);
        detDev.Connect(pitfall.Open);
        detDev.Connect(fence.Open);

        detDev.Connect(camera);
        detDev.Connect(pitfall);
        detDev.Connect(fence);

        detDev.Detect();
        
    }

    
}
