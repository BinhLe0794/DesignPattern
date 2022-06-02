using System;
namespace ObserverDesignPattern.Notifiers
{
    public class YoutubeNotifier : Observer
    {
        public YoutubeNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }
        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine($"Youtube Notifier with new Data : " +
                    $"name: {videoData.GetTitle()} " +
                    $"description: {videoData.GetDescription()} " +
                    $"fileName: {videoData.GetfileName()}");
            }
        }
    }
}

