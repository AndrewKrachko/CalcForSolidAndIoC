using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Interfaces;

namespace Calculator
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
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
