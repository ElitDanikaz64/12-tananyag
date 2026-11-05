namespace _12i_repo.Feladatok.Inherit
{
    public class Game : IDownloadable
    {
        private string _name;
        private int _sizeMb;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int SizeMb
        {
            get { return _sizeMb; }
            set { _sizeMb = value < 0 ? 0 : value; }
        }

        public Game(string name, int sizeMb)
        {
            Name = name;
            SizeMb = sizeMb;
        }


        public  int GetSizeMb()
        {
            return SizeMb;
        }

        public string GetDescription()
        {
            return $"{Name}, játék";
        }
    }
}
