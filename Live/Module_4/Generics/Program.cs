
namespace Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Point<float, double> p1 = new Point<float, double> { X = 10, Y = 2.5F };
        Console.WriteLine(p1);


        int a = 10;
        int b = 20;
        Console.WriteLine($"a={a}, b={b}");
        Swap<int>(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
       
    }

    //static void Swap(ref int aaa, ref int bbb)
    //{
    //   int tmp = aaa;
    //    aaa = bbb;
    //    bbb = tmp;
    //}
    //static void Swap(ref long aaa, ref long bbb)
    //{
    //    long tmp = aaa;
    //    aaa = bbb;
    //    bbb = tmp;
    //}
    //static void Swap(ref double aaa, ref double bbb)
    //{
    //    double tmp = aaa;
    //    aaa = bbb;
    //    bbb = tmp;
    //}
    static void Swap<T>(ref T aaa, ref T bbb)
    {
        T tmp = aaa;
        aaa = bbb;
        bbb = tmp;
    }
}
