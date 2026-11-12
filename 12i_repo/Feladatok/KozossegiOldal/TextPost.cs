namespace _12i_repo.Feladatok.KozossegiOldal
{
    public class TextPost : Post
    {
        private string _text;
        public string Text { get { return _text; } set { _text = value; } }


        public TextPost(string author, string text) : base(author)
        {
            Text = text;
        }

        public override string GetDescription()
        {
            string text = Text.Length > 20 ? $"{Text.Substring(0, 20)}..." : Text;
            return base.GetDescription() + $": {text}";
        }

        public override int Score()
        {
            return Likes;
        }
    }
}
