namespace Garbage;

internal class Program
{
    static Unmanaged um1 = new Unmanaged();
    static Unmanaged um2 = new Unmanaged(); 

    static void Main(string[] args)
    {
        um1.Open();
        try
        {
            //um2.Query(true);
        }
        catch (Exception ex)
        {
            //m1.Close();
        }
        finally 
        { 
            um1.Dispose(); 
        }
        um1 = null;

        
        using (um2)
        {
            um2.Open();
        }
        um2 = null;

        // Don't do this!!!!!!
        GC.Collect();
        GC.WaitForPendingFinalizers();

    }
}
