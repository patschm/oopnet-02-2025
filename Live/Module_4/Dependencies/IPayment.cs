namespace Dependencies
{
    public interface IPayment
    {
        bool HasPayed { get; }

        void Pay();
    }
}