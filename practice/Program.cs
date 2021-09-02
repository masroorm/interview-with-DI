namespace practice
{
    using practice.Interfaces;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using practice.Services;
    using System;

    class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            ExemplifyScoping(host.Services, "Scope 1");

            return host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureServices((_, services) =>
                   services
                   .AddScoped<ISort, SortService>()
                   .AddScoped<IBeginInterview, BeginInterviewService>()
                   .AddScoped<IRemoveDuplicates, RemoveDuplicatesService>());

        static void ExemplifyScoping(IServiceProvider services, string scope)
        {
            using IServiceScope serviceScope = services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;

            var startApp = provider.GetRequiredService<IBeginInterview>();
            startApp.StartInterviewQuestions();

            System.Environment.Exit(1);

            // OperationLogger logger = provider.GetRequiredService<OperationLogger>();
            // logger.LogOperations($"{scope}-Call 1 .GetRequiredService<OperationLogger>()");

            // Console.WriteLine("...");

            // logger = provider.GetRequiredService<OperationLogger>();
            // logger.LogOperations($"{scope}-Call 2 .GetRequiredService<OperationLogger>()");

            // Console.WriteLine();
        }
    }
}


