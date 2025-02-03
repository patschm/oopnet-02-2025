﻿using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Polly;
using Polly.Extensions.Http;
using System.Net;
using System.Net.Http.Headers;

namespace HttpClientApp;

// Used Nuget packages:
// Microsoft.Extensions.DependencyInjection
// Microsoft.Extensions.Http
// Microsoft.Extensions.Http.Polly
// Newtonsoft.Json
public class Program
{
    static void Main(string[] args)
    {
        //BasicClientAsync();
        //DIClient();
        //StrongClient();
        //PostClient();
        AuthClient();
        Console.ReadLine();
    }

    static HttpClient client = new HttpClient();
    private static async Task BasicClientAsync()
    {
        //var handler = new SocketsHttpHandler();
        //handler.MaxConnectionsPerServer = 1;
        //handler.PooledConnectionLifetime = TimeSpan.FromMinutes(15);
        var client = new HttpClient();

        client.BaseAddress = new Uri("https://localhost:8001/");
        var response = await client.GetAsync("WeatherForecast");
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine(response.Content.Headers.ContentType);
            var data = await response.Content.ReadAsStringAsync();
            Console.Write(data);
        }
    }

    private static void DIClient()
    {
        var factory = new DefaultServiceProviderFactory();
        var services = new ServiceCollection();
        var builder = factory.CreateBuilder(services);

        builder.AddHttpClient("weather", opts =>
        {
            opts.BaseAddress = new Uri("https://localhost:8001/");
        })
          .SetHandlerLifetime(TimeSpan.FromMinutes(1)); // Default is 4 minutes
           //                                              //.AddPolicyHandler(msg =>
           //                                              //{
           //                                              //    // Retry mechanisms
           //                                              //    // From Microsoft.Extensions.Http.Polly
           //                                              //    return HttpPolicyExtensions
           //                                              //        .HandleTransientHttpError()
           //                                              //        .OrResult(m => m.StatusCode == HttpStatusCode.NotFound)
           //                                              //        .WaitAndRetryAsync(3, retAttempt => TimeSpan.FromSeconds(5));
           //                                              //});

        var provider = builder.BuildServiceProvider();

        var clientFactory = provider.GetRequiredService<IHttpClientFactory>();
        HttpClient client = clientFactory.CreateClient("weather");
        var response = client.GetAsync("WeatherForecast").Result;
        if (response.IsSuccessStatusCode)
        {
            var strData = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(strData);
        }
    }
    private static void StrongClient()
    {
        var factory = new DefaultServiceProviderFactory();
        var services = new ServiceCollection();
        var builder = factory.CreateBuilder(services);

        builder.AddHttpClient<WeatherForecastService>(opts =>
        {
            opts.BaseAddress = new Uri("https://localhost:8001/");
        });
        //builder.AddTransient<WeatherForecastService>();

        var provider = builder.BuildServiceProvider();

        var service = provider.GetService<WeatherForecastService>();
        var result = service?.GetWeather();
        if (result != null)
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Date}, {item.TemperatureC}, {item.Summary}");
            }
    }
    private static void PostClient()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:8001/");

        var item = new WeatherForecast { Date = DateTime.Now, Summary = "Mottig", TemperatureC = 31 };
        var content = new StringContent(JsonConvert.SerializeObject(item));
         content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        var response = client.PostAsync("WeatherForecast", content).Result;


        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine(response.Headers.Location);
        }
    }
    private static void AuthClient()
    {
        var factory = new DefaultServiceProviderFactory();
        var services = new ServiceCollection();
        var builder = factory.CreateBuilder(services);
        builder.AddHttpClient("weather", opts =>
        {
            opts.BaseAddress = new Uri("https://localhost:8001/");
            opts.DefaultRequestHeaders.Authorization 
                = new AuthenticationHeaderValue("bearer", "token");
        });
        //.ConfigurePrimaryHttpMessageHandler(() =>
        //{
        //    return new HttpClientHandler
        //    {
        //        Credentials = new NetworkCredential("user", "pass", "domain"),
        //        UseCookies = true
        //    };
        //});

        var provider = builder.BuildServiceProvider();

        var clientFactory = provider.GetRequiredService<IHttpClientFactory>();
        var client = clientFactory.CreateClient("weather");
        var response = client.GetAsync("WeatherForecast").Result;
        if (response.IsSuccessStatusCode)
        {
            var strData = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(strData);
        }
    }
}