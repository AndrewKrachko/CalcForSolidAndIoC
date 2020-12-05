namespace Calculator.Interfaces
{
    public interface IEqData : IEqItem
    {
        double Value { get; }

        void SetValue(double value);
    }
}