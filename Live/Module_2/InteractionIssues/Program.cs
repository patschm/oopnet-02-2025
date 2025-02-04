namespace InteractionIssues;

internal class Program
{
    static void Main(string[] args)
    {
        ACME company = new ACME();
        Shengyu sy = new Shengyu();
        Jerry jr = new Jerry();
        Peter pt = new Peter();
        Bokito bt = new Bokito();
        RobotThingy rb = new RobotThingy();

        company.Hire(bt);
        company.Hire(pt);
        company.Hire(jr);
        company.Hire(sy);
        company.Hire(rb);

        company.Start();    
    }
}
