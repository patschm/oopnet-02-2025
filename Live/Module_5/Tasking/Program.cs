


using System.Linq.Expressions;

namespace Tasking;

internal class Program
{
    static void Main(string[] args)
    {
        //TheProblem();
        //SolveUsingTask();
        //ErrorHandling();
        //Cancellation();
        TheFinal();
        Console.WriteLine("The End");
        Console.ReadLine();
    }

    private static async void TheFinal()
    {
        try
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Tricky");
                Task.Delay(100).Wait();
                throw new Exception("Oooops");
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        int r1 = await LongAddAsync(4, 5);

        Task<int> t2 = Task.Run(() => LongAdd(12, 3));
        int result = await t2;
        Console.WriteLine(result);

        result = await Task.Run(() => LongAdd(12, 13));
        Console.WriteLine(result);

        result = await Task.Run(() => LongAdd(12, 13));
        Console.WriteLine(result);
    }

    private static void Cancellation()
    {
        CancellationTokenSource nikko = new CancellationTokenSource();

        CancellationToken bomb = nikko.Token;

        Task.Run(() =>
        {
            for (int i = 0; i < 100000; i++)
            {
                bomb.ThrowIfCancellationRequested();
                if (bomb.IsCancellationRequested)
                {
                    return;
                }
                Task.Delay(100).Wait();
                Console.WriteLine(i);
            }
        });


        //Task.Delay(10000).Wait();
        nikko.CancelAfter(10000);
    }

    private static void ErrorHandling()
    {
        Task.Run(() =>
        {
            Console.WriteLine("Tricky");
            Task.Delay(100).Wait();
            throw new Exception("Oooops");
        }).ContinueWith(t =>
        {
            Console.WriteLine(t.Status);
            if (t.Exception != null)
            {
                foreach (var ex in t.Exception.InnerExceptions)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //Console.WriteLine(t.Exception.InnerException.Message);
        });

        try
        {
            Task.Run(() =>
            {
                Console.WriteLine("Tricky");
                Task.Delay(100).Wait();
                throw new Exception("Oooops");
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SolveUsingTask()
    {
        Task t1 = new Task(() =>
        {
            int result = LongAdd(2, 3);
            Console.WriteLine(result);
        });

        //t1.Start();

        Task<int> t2 = Task.Run(() =>
        {
            int result = LongAdd(12, 3);
            return result;

            //Console.WriteLine(result);
        });

        t2.ContinueWith(pt =>
        {
            Console.WriteLine(pt.Result);
        });
        Console.WriteLine(t2.Status);
        //Console.WriteLine(t2.Result);

    }

    private static void TheProblem()
    {
        int result = LongAdd(2, 3);
        Console.WriteLine(result);
    }

    static int LongAdd(int a, int b)
    {
        Task.Delay(10000).Wait();
        return a + b;
    }
    static Task<int> LongAddAsync(int a, int b)
    {
        return Task.Run(() => LongAdd(a, b));
    }
}
