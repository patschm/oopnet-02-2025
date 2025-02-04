
namespace Basics;

// Inheritance. FountainPen derives from Pen inheriting all its properties and bahavior
// Sealed means in this case that you can't derive from FountainPen
sealed class FountainPen :Pen
{
    public int NumberOfWrites { get; set; } = 5;

    // override actives polymorfisme
    // Sealed in this place means the method is no longer virtual and cannot be overridden
    public sealed override void Draw(string text)
    {
        if(NumberOfWrites == 0)
        {
            Console.WriteLine("Empty");
            return;
        }
        Console.ForegroundColor = Color;
        Console.WriteLine($"The fountain pen writes {text} in linewidth {Linewidth}");
        Console.ResetColor();
        NumberOfWrites--;
    }
}
