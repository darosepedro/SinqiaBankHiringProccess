namespace SinqiaBankHiringProccess.Core.Observers
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(string message);
    }
}
