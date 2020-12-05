using System.Collections;
using System.Collections.Generic;

namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IResult
    {
        IEnumerable<string[]> GetResults();
        void SetResults(IEnumerable<string[]> results);
    }
}