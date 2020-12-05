using Calculator.Interfaces;

namespace Calculator
{
    /// <summary>
    /// Интерфейс IDataSource и Абстрактный класс DataSource созданы для соблюдения
    /// - Single responsibility principle, обеспечивающуся через выполнение задач по передаче
    /// текстовых данных из произвольного источника (в частности реализация в классе FileDataSource)
    /// - Open/Close principle через (виртуальный в DataSource) метод GetData(), объявленый
    /// в IDataSource, а также использоание 
    /// - Ксвенно Liskov Substitution Principle, через реализацию в методе GetData(), которая
    /// привызове не будет возвращать исключения.
    /// </summary>
    public abstract class DataSource : IDataSource
    {
        protected Status _status;
        protected string _data = "";

        public Status DataSourceStatus => _status;

        public virtual string GetData()
        {
            return _data;
        }
    }
}