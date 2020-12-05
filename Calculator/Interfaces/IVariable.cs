namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IVariable : IEqData
    {
        string Name { get; }

        void SetName(string name);
    }
}