
namespace RadioStation;


delegate void Method(string msg);

internal class Station
{
    public event Method Subscribers;

    public void Broadcast()
    {
        Console.WriteLine("We start the program");
        Subscribers("Hello Listeners");
    }
}
