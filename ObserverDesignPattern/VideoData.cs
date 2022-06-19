namespace ObserverDesignPattern;
public class VideoData : Subject
{
   
   private string _title;
   public string GetTitle() => _title;

   public void SetTitle(string value)
   {
      _title = value;
      VideoDataChanged();
   }
   
   private string _description;
   public string GetDescription() => _description;
   public void SetDescription(string value)
   {
      _description = value;
      VideoDataChanged();
   }
   
   private string _fileName;
   public string GetfileName() => _fileName;
   public void SetfileName(string value)
   {
      _fileName = value;
      VideoDataChanged();
   }
   
   private void VideoDataChanged()
   {
      NotifyObservers(this, null); // this = instance of class VideoData
      // Duyệt qua tất cả các phần từ đang subscribe 
   }
}