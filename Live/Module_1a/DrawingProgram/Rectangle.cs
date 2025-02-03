
namespace DrawingProgram;

internal class Rectangle
{
    #region Fields
    private int _width;
	private int _height;
    #endregion
    #region Properties
    public int Height
	{
		get { return _height; }
		set 
		{
			if (value >= 0) 
				_height = value; 
		}
	}
	public int Width
	{
		get { return _width; }
		set 
		{ 
			if (value >= 0)
				_width = value; 
		}
	}
    public ConsoleColor Color { get; set; }
    public Position Location { get; set; } = new Position();
    #endregion

    public void Draw()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Rectangle on position ({Location.X}, {Location.Y}) with width {Width} and height {Height}");
        Console.ResetColor();
    }
}
