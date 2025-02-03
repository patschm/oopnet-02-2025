namespace DrawingProgram;

internal class Circle
{
	private int _radius;

	public int Radius
	{
		get { return _radius; }
		set 
		{ 
			if (value >= 0 && value < 1000)
				_radius = value; 
		}
	}
	public Position Location { get; set; } = new Position();
    public ConsoleColor Color { get; set; }


	public void Draw()
	{
		Console.ForegroundColor = Color;
        Console.WriteLine($"Circle on position ({Location.X}, {Location.Y}) with radius  {Radius}");
		Console.ResetColor();
	}
}
