using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class DependencyInjectedLogic
    {
        private readonly ILogger _logger;

        public DependencyInjectedLogic(ILogger logger)
        {
            _logger = logger;
        }

        public double Multiply(double numberOne, double numberTwo)
        {
            _logger.LogInformation("Start multiplying");
            return numberOne * numberTwo;
        }
    }
}
