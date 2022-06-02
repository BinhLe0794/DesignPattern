using System;
namespace ObserverDesignPattern
{
    public class VideoData : Subject
    {
        private string _title;

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string value)
        {
            _title = value;
            VideoDataChanged();
        }

        private string _description;

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string value)
        {
            _description = value;
            VideoDataChanged();
        }

        private string _fileName;

        public string GetfileName()
        {
            return _fileName;
        }

        public void SetfileName(string value)
        {
            _fileName = value;
            VideoDataChanged();
        }

        private void VideoDataChanged()
        {
            NotifyObservers(this, null); // this = instance of class VideoData
        }
    }
}

