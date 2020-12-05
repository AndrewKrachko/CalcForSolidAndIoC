namespace Calculator.Interfaces
{
    /// <summary>
    /// Проявление принципа Interface Segregation через 1341329 миллионов маленьких интерфейсов
    /// </summary>
    public interface IDataPresenter
    {
        Status DataPresenterStatus { get; }
        void PresentData();
    }
}