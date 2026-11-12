using _12i_repo.Core;

namespace _12i_repo
{
    internal class Program
    {

        public static event Action FeladatMeghivas;
        public static ConsoleView ConsoleView { get; private set; }
        public static CommandExecuter CommandExecuter { get; private set; }
        public static FeladatRegistry FeladatRegistry { get; private set; }
        public static FeladatExecuter FeladatExecuter { get; private set; }


        public static event Action FeladatRegistring;

        public static bool ProgramRunning = true;

        static void Main(string[] args)
        {
            InitializeStuff();

            FeladatRegistry.PrintAllExecurtableFeladat();

            Console.WriteLine("\n------------------\n");

            while (ProgramRunning)
            {
                Console.Write("> ");
                string rawInput = ConsoleView.GetInput();

                CommandExecuter.ExecuteCommand(rawInput);
            }
        }

        private static void InitializeStuff()
        {
            ConsoleView = new ConsoleView();
            FeladatRegistry = new FeladatRegistry();
            CommandExecuter = new CommandExecuter();
            FeladatExecuter = new FeladatExecuter();
        }

    }
}
