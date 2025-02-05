
namespace MoreFun;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };

        Point p2 = new Point { X = 10, Y = 20 };

        Point p3 = p1 + p2;
        Console.WriteLine(p3);
        //DoSomething(p1);
        Console.WriteLine(p3);
    }

    private static void DoSomething(Point ppp)
    {
        ppp.X = 100;
        ppp.Y = 200;
    }
}
