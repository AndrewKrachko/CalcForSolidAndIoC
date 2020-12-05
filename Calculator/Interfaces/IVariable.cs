namespace Calculator.Interfaces
{
    public interface IVariable : IEqData
    {
        string Name { get; }

        void SetName(string name);
    }
}