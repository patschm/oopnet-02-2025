
namespace Basics;

// Inheritance. FountainPen derives from Pen inheriting all its properties and bahavior
internal class FountainPen :Pen
{
    public int NumberOfWrites { get; set; } = 5;

    public override void Draw(string text)
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
