using static System.Net.Mime.MediaTypeNames;

namespace _12i_repo.Feladatok.KozossegiOldal
{
    internal class ImagePost : Post
    {
        private int _imageCount;
        public int ImageCount { 
            get { return _imageCount; }
            set
            {
                if (value > 0 && value < 10)
                {
                    _imageCount = value;
                }
                else _imageCount = 1;
            }
        }


        public ImagePost(string author, int imageCount) : base(author)
        {
            ImageCount = imageCount;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", {ImageCount} kép";
        }

        public override int Score()
        {
            return Likes * 2;
        }
    }
}