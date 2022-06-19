namespace ObserverDesignPattern.Notifiers;
public class EmailNotifier : Observer
{
   public EmailNotifier(Subject subject)
   {
      Subject = subject;
      Subject.AttachObserver(this);
   }
   public override void Notify(Subject subject, object arg)
   {
      if( subject is VideoData videoData )
         Console.WriteLine("Email Notifier with new Data : "             +
                           $"name: {videoData.GetTitle()} "              +
                           $"description: {videoData.GetDescription()} " +
                           $"fileName: {videoData.GetfileName()}");
   }
}