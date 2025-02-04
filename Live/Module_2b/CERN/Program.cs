namespace CERN;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonvdMeer sm = new SimonvdMeer();

        //wk.Calculate(sm.Add, 4, 5);
        //wk.Calculate(sm.Subtract, 4, 5);

        //wk.Calculate()

        MathFunc f1 = sm.Add;
        f1 = f1 + sm.Subtract;
        f1 = f1 + sm.Add;

        foreach(var x in f1.GetInvocationList())
        {
            Console.WriteLine(x.Method.Name);
        }

        int res = f1(1, 2);

        Console.WriteLine(res);


    }
}
