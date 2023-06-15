namespace DependencyInjectionDemo
{
    public class DoSomething
    {
        public int a;
        public int b;
        public int r;

        private readonly ILogger _logger;

        public DoSomething(ILogger logger)
        {
            _logger = logger;

        }

        public void DDD()
        {
            _logger.Log("Constructor called", LogLevel.Verbose);

            a = 1;
            _logger.Log("int variable a initialized", LogLevel.Verbose);

            b = 2;
            _logger.Log("int variable b initialized", LogLevel.Verbose);

            r = a + b;
            _logger.Log("a+b put into variable r", LogLevel.Info);

            r++;
            _logger.Log("r incremented", LogLevel.Debug);

            r++;
            _logger.Log("r incremented again", LogLevel.Warning);

            try
            {
                r = r / 0;
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message, LogLevel.Error);
            }

        }
    }
}
