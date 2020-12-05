using System.Collections;
using System.Collections.Generic;

namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IEquationSet
    {
        int RemainingEquations { get; }
        int ProceedEquations { get; }
        IEnumerable<IEqItem> GetEquation();
    }
}