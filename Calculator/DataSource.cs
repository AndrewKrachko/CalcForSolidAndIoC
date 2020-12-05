using Calculator.Interfaces;

namespace Calculator
{
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