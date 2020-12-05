using Calculator.Interfaces;

namespace Calculator
{
    public class Number : IEqData
    {
        private double _value;
        public int Position { get; }
        public double Value => _value;

        public Number(int position)
        {
            Position = position;
        }

        public void SetValue(double value)
        {
            _value = value;
        }
    }
}