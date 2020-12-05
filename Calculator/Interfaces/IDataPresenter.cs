namespace Calculator.Interfaces
{
    public interface IDataPresenter
    {
        Status DataPresenterStatus { get; }
        void PresentData();
    }
}