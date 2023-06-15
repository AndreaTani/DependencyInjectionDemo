namespace DependencyInjectionDemo
{
    public class FileLogger : ILogger
    {
        public void Log(string message, LogLevel level)
        {
            string filename = "log.txt";

            if (level >= Program.logLevel)
            {
                string output = String.Format("{0} | {1}\t| {2}{3}", DateTime.Now, level.ToString(), message, Environment.NewLine);
                File.AppendAllText(filename, output);
            }
        }
    }
}
