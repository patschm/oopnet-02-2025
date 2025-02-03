namespace DrawingProgram;

internal class Program
{
    static void Main(string[] args)
    {
        Canvas canvas = new Canvas();

        Circle circle = new Circle { 
            Radius = 100,
            Location = new Position { X= 100, Y=200},
            Color = ConsoleColor.Red
        };

        Circle circle2 = new Circle
        {
            Radius = 100,
            Location = new Position { X = 100, Y = 200 },
            Color = ConsoleColor.Blue
        };

        //Circle[] array = new Circle[] { circle, circle2 };
        //Shape shape = circle;
        canvas.Assign(circle);

        Rectangle rectangle = new Rectangle
        {
            Color = ConsoleColor.Green,
            Width = 200,
            Height = 100,
            Location = new Position { X = 100, Y = 200 }
        };
        
        canvas.Assign(rectangle);

        Circle c3 = CreateCircle();
        canvas.Assign(c3);
    }

    static Circle CreateCircle()
    {
        Console.WriteLine("What's the X value");
        string sX = Console.ReadLine();
        Console.WriteLine("What's the Y value");
        string sY = Console.ReadLine();
        Console.WriteLine("What's the Radius");
        string sRadius = Console.ReadLine();
        Console.WriteLine("What Color (value betweenn 0 and 15)");
        string sColor = Console.ReadLine();

        Circle c = new Circle();
        c.Location = new Position { X = int.Parse(sX), Y = int.Parse(sY) };
        c.Color = (ConsoleColor)int.Parse(sColor);
        c.Radius = int.Parse(sRadius);
        return c;
    }
}
