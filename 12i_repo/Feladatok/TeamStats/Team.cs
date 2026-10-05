namespace _12i_repo.Feladatok.TeamStats
{
    public class Team
    {
        public string Name { get; }
        public List<Player> Players { get { return _players; } }

        private List<Player> _players;

        public Team(string name)
        {
            Name = name;
            _players = new List<Player>();
        }

        public bool AddPlayer(Player player)
        {
            if (player == null) return false;
            Players.Add(player);
            return true;
        }

        public Player FindByNumber(int number)
        {
            if (!_players.Where(x => x.Number == number).Any()) return;
            return _players.Where(x => x.Number == number).First();
        }

    }
}
