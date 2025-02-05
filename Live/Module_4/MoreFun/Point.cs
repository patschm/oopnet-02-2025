namespace MoreFun;

internal struct Point : IFormattable
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator+(Point left, Point right)
    {
        return new Point { X = left.X + right.X, Y = left.Y + right.Y };
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return ToString();
    }
}
