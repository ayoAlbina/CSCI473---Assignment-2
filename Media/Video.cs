using System;

namespace MediaPlayer.Media
{
    public class Video : IMedia
    {
        public string Title { get; }
        public TimeSpan Duration { get; }

        public Video(string title, TimeSpan duration)
        {
            Title = title;
            Duration = duration;
        }

        public void Play() => Console.WriteLine($"Playing video: {Title}");
        public void Stop() => Console.WriteLine($"Stopping video: {Title}");
    }
}