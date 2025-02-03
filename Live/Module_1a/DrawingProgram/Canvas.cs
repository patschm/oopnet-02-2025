namespace DrawingProgram;

internal class Canvas
{
    private List<Shape> _shapes = new List<Shape>();

    public void Refresh()
    {
        Console.Clear();
        foreach (Shape circle in _shapes)
        {
            circle.Draw();
        }
    }

    public void Assign(Shape shape)
    {
        _shapes.Add(shape);
        Refresh();
    }

}
