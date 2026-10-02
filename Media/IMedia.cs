using System;

namespace MediaPlayer.Media
{
    public interface IMedia : IPlayable
    {
        string Title { get; }
        TimeSpan Duration { get; }
    }
}