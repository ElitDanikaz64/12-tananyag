namespace _12i_repo.BorosB.MenuManager_2026_09_24 
{
    // 2.) Rename manually class
    public class ConsoleView : Shared.ProgramStartManager
    {
        // -- Feladat torso --

        public void ShowItem(MenuItem item)
        {
            Console.WriteLine(item.GetDiscription());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowItems(List<MenuItem> item)
        {
            item.ForEach(x => Console.WriteLine($"{x.GetDiscription()}, {MenuItem.Count} db"));
        }


        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            // MenuItem-ben van a kiirási megoldás
        }
    }
}
