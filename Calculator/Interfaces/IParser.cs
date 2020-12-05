using System.Collections.Generic;

namespace Calculator.Interfaces
{
    public interface IParser
    {
        Status ParserStatus { get; }
        IEquationSet[] Parse(IDataSource dataSource);
    }
}