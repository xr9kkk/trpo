using good1.Interfaces;

namespace good1.Services
{
    //Телебоков А. И. Codestyle 18. Кино, музыка, шоубизнес
    class Player
    {
        private readonly List<IPlayable> _playlist = new List<IPlayable>();
        public IReadOnlyList<IPlayable> GetPlaylist() => _playlist;

        public void AddToPlaylist(IPlayable film)
        {
            _playlist.Add(film);
        }

        public void PlayAll()
        {
            foreach (IPlayable film in _playlist)
            {
                film.Play();
            }
        }
    }
}