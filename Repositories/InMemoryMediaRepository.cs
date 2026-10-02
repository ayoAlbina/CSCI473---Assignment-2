using System.Collections.Generic;
using MediaPlayer.Media;

namespace MediaPlayer.Repositories
{
    public class InMemoryMediaRepository : IMediaRepository
    {
        private readonly List<IMedia> items = new List<IMedia>();

        public IEnumerable<IMedia> GetAll() => items;

        public void Add(IMedia item) => items.Add(item);
    }
}