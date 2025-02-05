namespace Dependencies
{
    public interface ICounter
    {
        int CounterValue { get; }

        void Increment();
    }
}