namespace _12i_repo.Feladatok.Inherit
{
    public class Movie : Content, IDownloadable
    {

        private int _durationMinutes;
        public int DurationMinutes
        {
            get { return _durationMinutes; }
            set 
            {
                if (value < 0)
                    _durationMinutes = 0;
                else
                    _durationMinutes = value;
            }
        }


        public Movie(string title, int releaseYear, int durationMinutes) : base(title, releaseYear)
        {
            DurationMinutes = durationMinutes;
        }

        public override int TotalMinutes()
        {
            return DurationMinutes;
        }

        public int GetSizeMb()
        {
            return DurationMinutes * 25;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, film, {(int)(DurationMinutes / 60)}:{DurationMinutes % 60} ";
        }

    }
}
