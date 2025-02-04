namespace EvolutionTheory;

delegate int MathDel(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2); //  m1.Invoke(1, 2);


        // 2005. Framework 2.0

        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;

        MathDel m3 = delegate (int x, int y)
        {
            return x + y + c;
        };

        result = m3(3, 4);

        // 2007. Framework 3.0 and later
        MathDel m4 =  (x, y) => x + y + c;
        result = m4(4, 5);

        // Procedures
        Action<string, int> a1 = (s, nr) => Console.WriteLine(s, nr);
        a1("Hi again! {0}", 42);

        // Functions
        Func<int, int, int> f1 = (a, b) => a + b;
        result = f1(5, 6);

        Func<int, int, int> f2 = Add;


        Console.WriteLine(result);
    }

    static int Add(int x, int y)
    {
        return x + y;
    }
}
