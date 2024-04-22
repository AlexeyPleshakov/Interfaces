using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Calculator : ICalculator
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger) 
        { 
            Logger = logger;
        }
        public void CalcSum(double x, double y)
        {
            Logger.Event("Calculator has started");
            var sum = x + y;
            Console.WriteLine($"Result: {sum}");
            Logger.Error("Calculator has stopped");
        }
    }
}
