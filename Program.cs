using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionDemo
{
    public class Program
    {
        public static LogLevel logLevel;

        static void Main(string[] args)
        {
            logLevel = LogLevel.Verbose;

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILogger, FileLogger>()
                .AddSingleton<DoSomething>()
                .BuildServiceProvider();

            var bar = serviceProvider.GetService<DoSomething>();
            bar.DDD();

            Console.WriteLine("r = " + bar.r.ToString());
        }
    }
}