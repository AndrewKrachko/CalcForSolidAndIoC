using System.Collections;
using System.Collections.Generic;

namespace Calculator.Interfaces
{
    public interface IEquationSet
    {
        int RemainingEquations { get; }
        int ProceedEquations { get; }
        IEnumerable<IEqItem> GetEquation();
    }
}