namespace _12i_repo.Feladatok.Inherit
{
    public class Phone 
    {
        private int _freeMbSpace;
        private List<IDownloadable> _downloads;
        private bool _isWifiOn;

        public int FreeMbSpace { get { return _freeMbSpace; } }
        public List<IDownloadable> Downloads { get { return _downloads; } }
        public bool IsWifiOn
        {
            get { return _isWifiOn; }
            set { _isWifiOn = value; }
        }

        public Phone(int freeMbSpace)
        {
            _freeMbSpace = freeMbSpace;
            _downloads = new();
            _isWifiOn = true;
        }

        public bool Download(IDownloadable item)
        {
            if (item.GetSizeMb() > _freeMbSpace) return false;
            if (!_isWifiOn && item.GetSizeMb() > 2000) return false;

            _downloads.Add(item);
            _freeMbSpace -= item.GetSizeMb();

            return true;
        }

    }
}
