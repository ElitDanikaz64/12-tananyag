namespace _12i_repo.Feladatok.Inherit
{
    public abstract class Content
    {
        private string _title;
        private int _releaseYear;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value >= 1900 && value <= 2026)
                    _releaseYear = value;
                else _releaseYear = 0;
            }
        }

        public Content(string title, int releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }

        public abstract int TotalMinutes();

        public string LengthText()
        {
            return $"{(int)(TotalMinutes() / 60)} óra {TotalMinutes() % 60} prec";
        }

        public virtual string GetDescription()
        {
            if (ReleaseYear == 0)
                return $"{Title} (ismeretlen év)";
            else
                return $"{Title} ({ReleaseYear})";
        }
    }
}
