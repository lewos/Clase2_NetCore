using Microsoft.Extensions.Logging;
using System;

namespace ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Este es un mensaje del log de Consola");
            Console.ReadKey();

        }
    }
}
