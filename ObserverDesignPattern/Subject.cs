namespace ObserverDesignPattern;
public class Subject
{
   private readonly List<Observer> _observer = new();
   
   public void AttachObserver(Observer observer)
   {
      _observer.Add(observer);
   }
   public void DetachObserver(Observer observer)
   {
      _observer.Remove(observer);
   }
   
   public void NotifyObservers(Subject subject, object arg)
   {
      _observer.ForEach(observer => observer.Notify(subject, arg));
   }
}