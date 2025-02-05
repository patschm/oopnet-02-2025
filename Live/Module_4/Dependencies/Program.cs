using Microsoft.Extensions.DependencyInjection;
using System.Runtime.Intrinsics;

namespace Dependencies;

internal class Program
{
    static void Main(string[] args)
    {
        ServiceCollection services = new ServiceCollection();
        var factory = new DefaultServiceProviderFactory();
        var bld = factory.CreateBuilder(services);

        services.AddTransient<ICounter, FaultyCounter>();
        // services.AddSingleton<ICounterV2, FaultyCounter
        services.AddTransient<IPayment, Payment>();
        services.AddTransient<IHostThingy, HostThingy>();

        var prov = bld.BuildServiceProvider();

        //Counter c1 = new Counter();
        // ICounter c1 = prov.GetRequiredService<ICounter>();
        //.Increment();
        //.WriteLine(c1.CounterValue);
        //var c2 = prov.GetRequiredService<ICounterV2>();
        //c2.Increment();
        //Console.WriteLine(c2.CounterValue);

        //var counter = new FaultyCounter(new Payment());
        //var host = new HostThingy(counter);

        var host = prov.GetRequiredService<IHostThingy>();

        host.Run();

    }
}
