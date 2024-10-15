namespace SinqiaBankHiringProccess.Core.Observers
{
    public class EventNotifier : IObservable
    {
        private readonly List<IObserver> _observers = new();

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
