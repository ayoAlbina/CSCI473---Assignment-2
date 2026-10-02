using System;

namespace MediaPlayer.Media
{
    public class Song : IMedia, IDownloadable
    {
        public string Title { get; }
        public TimeSpan Duration { get; }

        public Song(string title, TimeSpan duration)
        {
            Title = title;
            Duration = duration;
        }

        public void Play() => Console.WriteLine($"Playing song: {Title}");
        public void Stop() => Console.WriteLine($"Stopping song: {Title}");
        public void Download(string destination) => Console.WriteLine($"Downloading song '{Title}' to {destination}");
    }
}