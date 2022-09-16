namespace Observer
{
    public interface IObservable
    {
        void NotificarObserver();
        void RegistrarObserver(IObserver observer);
        void RemoverObserver(IObserver observer);
    }
}
