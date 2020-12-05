using System;
using Calculator.Interfaces;

namespace Calculator
{

    /// <summary>
    /// Реализация принципа Liskov Substitution через обеспечение обратной совместимости
    /// с классом Number, достигающееся через расширение класса-родителя
    /// </summary>
    public class Variable : Number
    {
        private double _value;
        private string _name;

        public int Position { get; }

        public string Name { get; }
        public double Value => _value;

        public Variable(int position) : base(position)
        {
        }

        public void SetName(string name)
        {
            _name=name;
        }
    }
}