namespace DependencyInjectionDemo
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message, LogLevel level)
        {
            if (level >= Program.logLevel)
            {
                string output = String.Format("{0} | {1} | {2}", DateTime.Now, level.ToString(), message);
                Console.WriteLine(output);
            }
        }
    }
}
