namespace ObserverDesignPattern.Notifiers;
public class PhoneNotifier : Observer
{
   public PhoneNotifier(Subject subject)
   {
      Subject = subject;
      Subject.AttachObserver(this);
   }
   public override void Notify(Subject subject, object arg)
   {
      if( subject is VideoData videoData )
         Console.WriteLine("Phone Notifier with new Data : "             +
                           $"name: {videoData.GetTitle()} "              +
                           $"description: {videoData.GetDescription()} " +
                           $"fileName: {videoData.GetfileName()}");
   }
}