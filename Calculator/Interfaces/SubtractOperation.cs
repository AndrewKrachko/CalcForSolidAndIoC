using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Interfaces
{
    public class SubtractOperation : IEqOperation
    {
        public int Position { get; }

        public SubtractOperation(int position)
        {
            Position = position;
        }

        public void Operate(IEqData operatorA, IEqData operatorB)
        {
            operatorA.SetValue(operatorA.Value - operatorB.Value);
        }
    }
}
