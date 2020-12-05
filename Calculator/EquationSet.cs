using System.Collections.Generic;
using Calculator.Interfaces;

namespace Calculator
{
    public class EquationSet : IEquationSet
    {
        private IEnumerable<IEqItem> _eqItems;
        public int RemainingEquations { get; }
        public int ProceedEquations { get; }

        public EquationSet(IEnumerable<IEqItem> eqItems)
        {
            _eqItems = eqItems;
        }

        public IEnumerable<IEqItem> GetEquation()
        {
            return _eqItems;
        }
    }
}