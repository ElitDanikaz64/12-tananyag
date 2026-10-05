namespace _12i_repo.Feladatok.TeamStats
{
    public class ConsoleView
    {
        public void ShowPlayer(Player player)
        {
            Console.WriteLine(player.GetDescription());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        
        public void ShowPlayers(List<Player> players)
        {
            players.ForEach(x=> Console.WriteLine(x.GetDescription()));
        }

    }
}
