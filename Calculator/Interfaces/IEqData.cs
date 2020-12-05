namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IEqData : IEqItem
    {
        double Value { get; }

        void SetValue(double value);
    }
}