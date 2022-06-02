
using ObserverDesignPattern;
using ObserverDesignPattern.Notifiers;

Console.WriteLine(">>>>>> Start:");

var videodata = new VideoData();

var emailNotifier = new EmailNotifier(videodata);
var phoneNotifier = new PhoneNotifier(videodata);
var youtubeNotifier = new YoutubeNotifier(videodata);

videodata.SetTitle("Observer Design Pattern");

videodata.DetachObserver(youtubeNotifier);
Console.WriteLine("----------------------");
videodata.SetDescription("New Description");

