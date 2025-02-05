namespace Generics;

internal class Point<TTTT, UUUU>
{
    public TTTT X { get; set; }
    public UUUU Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
