using Calculator.Interfaces;

namespace Calculator
{
    public class SumOperation : IEqOperation
    {
        public int Position { get; }

        public SumOperation(int position)
        {
            Position = position;
        }

        public void Operate(IEqData operatorA, IEqData operatorB)
        {
            operatorA.SetValue(operatorA.Value + operatorB.Value);
        }
    }
}