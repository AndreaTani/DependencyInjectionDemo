namespace DependencyInjectionDemo
{
    internal class DoSomething
    {
        public int a;
        public int b;
        public int r;

        internal DoSomething(ILogger logger)
        {
            logger.Log("Constructor called", LogLevel.Verbose);

            a = 1;
            logger.Log("int variable a initialized", LogLevel.Verbose);

            b = 2;
            logger.Log("int variable b initialized", LogLevel.Verbose);

            r = a + b;
            logger.Log("a+b put into variable r", LogLevel.Info);

            r++;
            logger.Log("r incremented", LogLevel.Debug);

            r++;
            logger.Log("r incremented again", LogLevel.Warning);

            try
            {
                r = r / 0;
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message, LogLevel.Error);
            }
        }
    }
}
