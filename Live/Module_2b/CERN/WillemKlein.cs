namespace CERN;

delegate int MathFunc(int a, int b);


/// <summary>
/// This guy does all the work
/// </summary>
internal class WillemKlein
{
    /// <summary>
    /// Calculate something
    /// </summary>
    /// <param name="f1">The instruction for the calculation</param>
    /// <param name="x">a number</param>
    /// <param name="y">a number</param>
    public void Calculate(MathFunc f1, int x, int y)
    {
        Console.WriteLine("Willem starts to calculate...");
        int result = f1(x,y);

        // TODO

        Console.WriteLine($"The answer is {result}");
    }
}
