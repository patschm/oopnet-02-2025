namespace RadioStation;

internal class Program
{
    static void Main(string[] args)
    {
        Station r538 = new Station();
        r538.Subscribers += ReceiveMethods.BySMS;
        r538.Subscribers += ReceiveMethods.ByEmail;
        r538.Subscribers += ReceiveMethods.ByPigeon;
        r538.Subscribers += ReceiveMethods.BySMS;
        r538.Subscribers += ReceiveMethods.BySMS;
        r538.Subscribers += ReceiveMethods.ByEmail;
        r538.Subscribers += ReceiveMethods.ByPigeon;
        r538.Subscribers += ReceiveMethods.BySMS;
        r538.Subscribers += ReceiveMethods.BySMS;
        r538.Subscribers += ReceiveMethods.ByEmail;
        r538.Subscribers += ReceiveMethods.ByPigeon;
        r538.Subscribers += ReceiveMethods.BySMS;

        r538.Broadcast();
    }
}
