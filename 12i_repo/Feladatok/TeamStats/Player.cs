namespace _12i_repo.Feladatok.TeamStats
{
    public class Player
    {
        private string _name;
        private string _position;
        private int _number;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0 || value > 99) return;
                _number = value;
            }
        }

        public static int Count = 0;

        public Player(string name, string pos, int number)
        {
            Name = name;
            Position = pos;
            Number = number;

            Count++;
        }


        private int _gamesPlayed = 0;
        private int _totalPoints = 0;

        public int GamesPlayed { get { return _gamesPlayed; } }
        public int TotalPoints { get { return _totalPoints; } }

        public bool AddGame(int points)
        {
            if (points < 0) return false;
            _gamesPlayed++;
            _totalPoints += points;
            return true;
        }


        public double AveragePoints()
        {
            return TotalPoints / GamesPlayed;
        }

        public string GetDescription()
        {
            return $"#{Number} {Name} ({Position}), átlag: {Math.Round(AveragePoints(), 1)} pont";
        }
    }
}
