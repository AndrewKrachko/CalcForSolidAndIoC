using System;
using Calculator.Interfaces;

namespace Calculator
{
    public class Variable : IVariable
    {
        private double _value;
        private string _name;

        public int Position { get; }

        public string Name { get; }
        public double Value => _value;

        public Variable(int position)
        {
            Position = position;
            _value = Double.NaN;
        }

        public void SetValue(double value)
        {
            _value = value;
        }

        public void SetName(string name)
        {
            _name=name;
        }
    }
}