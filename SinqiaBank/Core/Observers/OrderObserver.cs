namespace SinqiaBankHiringProccess.Core.Observers
{
    public class OrderObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[Order] Notificação recebida: {message}");
        }
    }
}
