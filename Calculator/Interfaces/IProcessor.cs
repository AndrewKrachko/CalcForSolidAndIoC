namespace Calculator.Interfaces
{
    public interface IProcessor
    {
        Status Status { get; }
        void SetEquation(IEquationSet equationSet);
        void StartCalculation();
        void GetResult(IResult result);
    }
}