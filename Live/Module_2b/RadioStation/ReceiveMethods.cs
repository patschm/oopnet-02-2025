
namespace RadioStation;

internal class ReceiveMethods
{
    public static void ByEmail(string msg)
    {
        Console.WriteLine($"Received by Email: {msg}");
    }
    public static void BySMS(string msg)
    {
        Console.WriteLine($"Received by SMS: {msg}");
    }
    public static void ByPigeon(string msg)
    {
        Console.WriteLine($"Received by pigeon: {msg}");
    }
}
