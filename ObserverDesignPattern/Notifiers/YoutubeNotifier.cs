namespace ObserverDesignPattern.Notifiers;
public class YoutubeNotifier : Observer
{
   public YoutubeNotifier(Subject subject)
   {
      Subject = subject;
      Subject.AttachObserver(this); // Subscribe the list notification
   }
   
   public override void Notify(Subject subject, object arg)
   {
      // bắn ra thông báo đối tượng đã được cập nhật thông tin mới
      if( subject is VideoData videoData )
         Console.WriteLine("Youtube Notifier with new Data : "           +
                           $"name: {videoData.GetTitle()} "              +
                           $"description: {videoData.GetDescription()} " +
                           $"fileName: {videoData.GetfileName()}");
   }
}