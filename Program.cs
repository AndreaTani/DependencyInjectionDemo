namespace DependencyInjectionDemo
{
    internal class Program
    {
        internal static LogLevel logLevel;

        static void Main(string[] args)
        {
            logLevel = LogLevel.Verbose;

            var ds = new DoSomething(new FileLogger());

            Console.WriteLine("r = " + ds.r.ToString());
        }
    }
}