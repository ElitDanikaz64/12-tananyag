namespace _12i_repo.Feladatok.Inherit
{
    internal class Series : Content, IDownloadable
    {
        private int _episodes;
        private int _episodeMintues;

        public int Episodes
        {
            get { return _episodes; }
            set
            {
                if (value < 0)
                    _episodes = 0;
                else
                    _episodes = value;
            }
        }

        public int EpisodeMintues
        {
            get { return _episodeMintues; }
            set
            {
                if (value < 0)
                    _episodeMintues = 0;
                else
                    _episodeMintues = value;
            }
        }

        public Series(string title, int releaseYear, int episodes, int episodeMinutes) : base(title, releaseYear)
        {
            Episodes = episodes;
            EpisodeMintues = episodeMinutes;
        }


        public override int TotalMinutes()
        {
            return Episodes * EpisodeMintues;
        }

        public int GetSizeMb()
        {
            return TotalMinutes() * 20;
        }

        public override string GetDescription()
        {
            return $"{Title} ({ReleaseYear}), sorozat, {Episodes} rész, {(int)(TotalMinutes() / 60)} óra {TotalMinutes() % 60} perc";
        }
    }
}
