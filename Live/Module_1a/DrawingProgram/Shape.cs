
namespace DrawingProgram;

class Shape
{
    public Position Location { get; set; } = new Position();
    public ConsoleColor Color { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Drawing something");
    }
}
