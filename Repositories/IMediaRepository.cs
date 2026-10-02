using System.Collections.Generic;
using MediaPlayer.Media;

namespace MediaPlayer.Repositories
{
    public interface IMediaRepository
    {
        IEnumerable<IMedia> GetAll();
        void Add(IMedia item);
    }
}