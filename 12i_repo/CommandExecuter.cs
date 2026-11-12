namespace _12i_repo
{
    internal class CommandExecuter
    {
        public void ExecuteCommand(string raw)
        {
            Console.WriteLine();
            if (Program.FeladatRegistry.FeladatokById.ContainsKey(raw))
                Program.FeladatExecuter.ExecuteFeladatMain(raw);
            else if (raw.ToLower() == "exit")
                Program.ProgramRunning = false;
            else if (raw.ToLower() == "list")
                Program.FeladatRegistry.PrintAllExecurtableFeladat();
            else
                Program.ConsoleView.Error($"A megadott parancs nem ismert. Parancs amit megadtál: {raw}");
            Console.WriteLine();
        }

        public CommandExecuter() { }

    }
}
