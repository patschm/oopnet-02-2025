
namespace Dependencies;

public class Payment : IPayment
{
    private bool hasPayed = false;

    public bool HasPayed { get => hasPayed; }
    public void Pay()
    {
        Console.WriteLine("Paying...");
        hasPayed = true;
    }
}
