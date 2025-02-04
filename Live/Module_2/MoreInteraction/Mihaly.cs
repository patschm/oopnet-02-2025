namespace MoreInteraction;

delegate void SomeThing();


internal class Mihaly
{
    public void ExecuteSometing(SomeThing some)
    {
        Console.WriteLine("Mihaly executes the following");
        some();
    }
}
