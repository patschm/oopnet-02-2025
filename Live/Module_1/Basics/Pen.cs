namespace Basics;

// Blueprint of a Pen object
class Pen
{
    public const int MAX_LINEWIDTH = 64;
    // Field. We use fields to store properties
    private int _linewidth = 10;
    //private ConsoleColor _color = ConsoleColor.Black;

    // Properties. Use properties to regulate values to your fields
    // Encapsulation
    public int Linewidth
    {
        get
        {
            return _linewidth;
        }
        set
        {
            if (value >= 0 && value < MAX_LINEWIDTH)
            {
                _linewidth = value;
            }
        }
    }
    // Auto generating properties
    public ConsoleColor Color { get; set; } = ConsoleColor.Black;

    // This C++-ish things are not needed in C#
    //public void SetLinewidth(int width)
    //{
    //    if (width >= 0 && width < 64) 
    //    {
    //    _linewidth = width;
    //    }
    //}
    //public int GetLinewidth()
    //{
    //    return _linewidth;
    //}
    // Behavior is defined in Methods
    public void Draw(string text)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"The pen writes {text} in linewidth {Linewidth}");
        Console.ResetColor();
    }

    // Constructors
    // Provides default values for your fields
    // Use constructors to force the user to specify values.
    // Also for DI

    //public Pen() :this(10, ConsoleColor.Black)
    //{
    //}

    //public Pen(int linewidth, ConsoleColor color)
    //{
    //    Linewidth = linewidth;
    //    _color = color;
    //}
}
