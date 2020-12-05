namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IProcessor
    {
        Status Status { get; }
        void SetEquation(IEquationSet equationSet);
        void StartCalculation();
        void GetResult(IResult result);
    }
}