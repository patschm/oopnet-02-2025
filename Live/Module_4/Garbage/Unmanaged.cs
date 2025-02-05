namespace Garbage;

internal class Unmanaged : IDisposable
{
    private static bool isOpen = false;

    public void Open()
    {
        if (!isOpen)
        {
            Console.WriteLine("Opening a database");
            isOpen = true;
        }
        else
        {
            Console.WriteLine("Database is in use");
        }
    }
    public void Query(bool withCrash)
    {
        if (withCrash) throw new Exception("Ooops");
    }
    public void Close()
    {
        Console.WriteLine("Closing the database");
        isOpen = false;
    }

    public void Dispose()
    {
        Close();
        GC.SuppressFinalize(this);
    }

    ~Unmanaged()
    {
        Close();
    }
}
