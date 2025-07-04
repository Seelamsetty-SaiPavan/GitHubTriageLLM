using System;
using Hangfire;
using Hangfire.MemoryStorage;

class Program
{
    static void Main()
    {
        GlobalConfiguration.Configuration
            .UseMemoryStorage();

        using (var server = new BackgroundJobServer(new BackgroundJobServerOptions
        {
            WorkerCount = 5,
            Queues = new[] { "default" }
        }))
        {
            Console.WriteLine("Scheduling jobs...");

            for (int i = 0; i < 10000; i++)
            {
                BackgroundJob.Schedule(() => Console.WriteLine($"Scheduled Job {i}"), TimeSpan.FromSeconds(30));
            }

            Console.WriteLine("All jobs scheduled. Monitoring...");
            Console.ReadLine();
        }
    }
}