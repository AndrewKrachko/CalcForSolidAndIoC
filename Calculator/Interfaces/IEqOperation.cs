namespace Calculator.Interfaces
{
    public interface IEqOperation : IEqItem
    {
        void Operate(IEqData operatorA, IEqData operatorB);
    }
}