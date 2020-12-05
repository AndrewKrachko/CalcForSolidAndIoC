using System.Collections.Generic;

namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IParser
    {
        Status ParserStatus { get; }
        IEquationSet[] Parse(IDataSource dataSource);
    }
}