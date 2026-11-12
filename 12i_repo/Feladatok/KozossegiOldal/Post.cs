namespace _12i_repo.Feladatok.KozossegiOldal
{
    public abstract class Post : IReporatble
    {
        private string _author;
        private int _likes;
        private int _reports;

        public string Author { get { return _author; } set { _author = value; } }
        public int Likes
        {
            get { return _likes; }
        }

        public Post(string author)
        {
            Author = author;
        }

        public virtual bool Like()
        {
            _likes++;
            return true;
        }

        public virtual string GetDescription()
        {
            return $"{Author}, {Likes} kedvelés.";
        }

        public abstract int Score();

        public void Report()
        {
            _reports++;
        }

        public int ReportCount()
        {
            return _reports;
        }

    }
}
