namespace DrawingProgram;

internal class Canvas
{
	private List<Circle> _circles = new List<Circle>();
	private List<Rectangle> _rectangles = new List<Rectangle>();

	public void Refresh()
	{ 
		Console.Clear();
		foreach(Circle circle in _circles)
		{
			circle.Draw();	
		}
		foreach(var rect in _rectangles)
		{
			rect.Draw();
		}
	}

	public void AssignCircle(params Circle[] circles)
	{
		foreach (var circle in circles)
		{
            _circles.Add(circle);
        }
		Refresh();
	}
	public void AssignRectangle(Rectangle rectangle)
	{
		_rectangles.Add(rectangle);
		Refresh();
	}
}
