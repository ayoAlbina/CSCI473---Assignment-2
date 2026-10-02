using System;

namespace MediaPlayer.Media
{
    public class Podcast : IMedia, IDownloadable
    {
        public string Title { get; }
        public TimeSpan Duration { get; }

        public Podcast(string title, TimeSpan duration)
        {
            Title = title;
            Duration = duration;
        }

        public void Play() => Console.WriteLine($"Playing podcast: {Title}");
        public void Stop() => Console.WriteLine($"Stopping podcast: {Title}");
        public void Download(string destination) => Console.WriteLine($"Downloading podcast '{Title}' to {destination}");
    }
}