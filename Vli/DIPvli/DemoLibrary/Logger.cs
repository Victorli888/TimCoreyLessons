using System;

namespace DemoLibrary
{
    /// <summary>
    /// As you can see our Logger Class does not depend on any other modules so we would considder it as a low level module
    /// </summary>
    public class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Write to Console: {msg}");
        }
    }
}