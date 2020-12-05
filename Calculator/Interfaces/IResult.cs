using System.Collections;
using System.Collections.Generic;

namespace Calculator.Interfaces
{
    public interface IResult
    {
        IEnumerable<string[]> GetResults();
        void SetResults(IEnumerable<string[]> results);
    }
}