namespace Dependencies
{
    internal interface ICounterV2
    {
        int CounterValue { get; }

        void Increment();
        void Decrement();
    }
}