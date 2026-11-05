namespace _12i_repo
{
    internal class FeladatExecuter
    {

        internal void ExecuteFeladatMain(string feladatId)
        {
            if (!Program.FeladatRegistry.FeladatokById.ContainsKey(feladatId))
            {
                Program.ConsoleView.Warn("Nem ismert feladat név.");
                return;
            }
            
            Program.FeladatRegistry.FeladatokById[feladatId].Invoke();

        }
    }
}
