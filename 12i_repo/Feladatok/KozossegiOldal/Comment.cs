namespace _12i_repo.Feladatok.KozossegiOldal
{
    public class Comment : IReporatble
    {
        private string _author;
        private string _text;

        public string Author { get { return _author; } set { _author = value; } }
        public string Text { get { return _text; } set { _text = value; } }
        

        public Comment(string author, string text, Post parentPost)
        {
            
        }
    }
}
