using System.Threading.Channels;

namespace _12i_repo.Feladatok.TeamStats
{
    public class Program : Shared.OraiFeladat
    {
        public override void Main()
        {

            ConsoleView cv = new ConsoleView();

            Player p1 = new Player("John Doe 1", "Defender", 1);
            Player p2 = new Player("John Doe 2", "Atacker", 2);
            Player p3 = new Player("John Doe 3", "Atacker", 4);
            Player p4 = new Player("John Doe 4", "Defender", 7);
            Player p5 = new Player("John Doe 5", "Goalkeeper", 420);

            if (!p1.AddGame(50)) cv.ShowMessage("Nem sikerült hozzáadni.");
            if (!p2.AddGame(20)) cv.ShowMessage("Nem sikerült hozzáadni.");
            if (!p3.AddGame(-1)) cv.ShowMessage("Nem sikerült hozzáadni.");
            if (!p5.AddGame(25)) cv.ShowMessage("Nem sikerült hozzáadni.");

            cv.ShowMessage($"Player.Count: {Player.Count}");

            Team team = new Team("E");

            team.AddPlayer(p1);
            team.AddPlayer(p2);
            team.AddPlayer(p3);
            team.AddPlayer(p4);
            team.AddPlayer(p5);

            cv.ShowPlayer(team.FindByNumber(5));
            cv.ShowPlayer(team.FindByNumber(7));

        }
    }
}
