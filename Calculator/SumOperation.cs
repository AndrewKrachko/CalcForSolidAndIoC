using Calculator.Interfaces;

namespace Calculator
{
    /// <summary>
    /// Реализация принципа Single Responsibility через обеспечение обратной совместимости
    /// с классами SumOperation, AssignOperation, SubtractOperation
    /// </summary>
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