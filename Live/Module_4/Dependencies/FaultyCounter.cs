namespace Dependencies;

public class FaultyCounter : ICounter, ICounterV2
{
    private int counter = 0;
    private readonly IPayment _paymentService;

    public FaultyCounter(IPayment payment)
    {
        _paymentService = payment;
    }
    public int CounterValue { get => counter; }

    public void Decrement()
    {
        if (_paymentService.HasPayed)
            counter++;
        else
        {
            Console.WriteLine("Do you want to pay?");
            _paymentService.Pay();
        }
    }

    public void Increment()
    {
        if (_paymentService.HasPayed)
            counter--;
        else
        {
            Console.WriteLine("Do you want to pay?");
            _paymentService.Pay();
        }
    }
}
