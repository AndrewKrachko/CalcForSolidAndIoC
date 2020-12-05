using Calculator.Interfaces;

namespace Calculator
{
    public class AssignOperation : IEqOperation
    {
        public int Position { get; }

        public AssignOperation(int position)
        {
            Position = position;
        }

        public void Operate(IEqData operatorA, IEqData operatorB)
        {
            operatorA.SetValue(operatorB.Value);
        }
    }
}