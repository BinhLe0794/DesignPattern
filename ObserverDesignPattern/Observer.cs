using System;
namespace ObserverDesignPattern
{
    //su dung abstract class de ke thua va overide lai function
    public abstract class Observer
    {

        protected Subject subject;
        public abstract void Notify(Subject subject, object arg);
    }
}

