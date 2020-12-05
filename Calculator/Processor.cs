using System;
using Calculator.Interfaces;

namespace Calculator
{
    public class Processor : IProcessor
    {
        public Status Status { get; }
        public void SetEquation(IEquationSet equationSet)
        {
            throw new NotImplementedException();
        }

        public void StartCalculation()
        {
            throw new NotImplementedException();
        }

        public void GetResult(IResult result)
        {
            throw new NotImplementedException();
        }
    }
}
