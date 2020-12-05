namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IDataSource
    {
        Status DataSourceStatus { get; }
        string GetData();
    }
}