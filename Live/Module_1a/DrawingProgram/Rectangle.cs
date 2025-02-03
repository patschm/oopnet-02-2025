
namespace DrawingProgram;

internal class Rectangle: Shape
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
    #endregion

    public override void Draw()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Rectangle on position ({Location.X}, {Location.Y}) with width {Width} and height {Height}");
        Console.ResetColor();
    }
}
