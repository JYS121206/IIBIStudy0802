public interface ISubject
{
    void Add(IObserver observer);
    void Delete(IObserver observer);
    void Notify();
}
