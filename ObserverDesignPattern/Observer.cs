namespace ObserverDesignPattern;
//su dung abstract class de ke thua va overide lai function
public abstract class Observer
{
   protected Subject Subject; // chỉ truy cập trong lớp nội bộ or lớp chứa nó
   public abstract void Notify(Subject subject, object arg);
}