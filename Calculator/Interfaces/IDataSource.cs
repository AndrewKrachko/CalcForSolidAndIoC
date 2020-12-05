namespace Calculator.Interfaces
{
    public interface IDataSource
    {
        Status DataSourceStatus { get; }
        string GetData();
    }
}