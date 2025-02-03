namespace Basics;


internal class Program
{
    static void Main(string[] args)
    {
       // Big bang of the virtual world
       // p1 is my object
       Pen p1 = new Pen();

        p1.Color = ConsoleColor.Green;
        //p1._linewidth = -15;
        p1.Linewidth = -15;
        Console.WriteLine(p1.Linewidth);

        p1.Draw("Hello World");
        

        Pen p2 = new Pen { Color = ConsoleColor.Red, Linewidth = 15 };
        //p2.SetLinewidth(15);
        p2.Draw("Hi there!");

        // p1 = 1;

        //German g1 = new Heinz();
        // Generalize
        Pen p3 = new FountainPen
        {
            Color = ConsoleColor.Red,
            Linewidth = 15,
            NumberOfWrites = 4
        };

        // Don't do this unless good reason (which are rare)
        if (p3 is FountainPen)
            (p3 as FountainPen).NumberOfWrites = 3;
      

        for (int i = 0; i < 7; i++)
        { 
            p3.Draw($"Hello World {i}");
        }


        // Big Crunch where everything ends.
    }
}


