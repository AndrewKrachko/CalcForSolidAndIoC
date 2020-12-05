﻿namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IEqOperation : IEqItem
    {
        void Operate(IEqData operatorA, IEqData operatorB);
    }
}