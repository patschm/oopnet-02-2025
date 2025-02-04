namespace MoreInteraction;

internal class Program
{
    static void Main(string[] args)
    {
        Mihaly mihaly = new Mihaly();
        Patrick p = new Patrick();

        //p.CollectThings();

        mihaly.ExecuteSometing(p.CollectThings);
        mihaly.ExecuteSometing(Explode);
    }

    static void Explode()
    {
        Console.WriteLine("Kaboooon");
    }
}
