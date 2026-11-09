using _12i_repo.Core;

namespace _12i_repo
{
    internal class Program
    {

        public static ConsoleView ConsoleView { get; private set; }
        public static FeladatRegistry FeladatRegistry { get; private set; }
        public static FeladatExecuter FeladatExecuter { get; private set; }


        public static event Action FeladatRegistring;

        static void Main(string[] args)
        {
            InitializeStuff();

            FeladatRegistring?.Invoke();

            FeladatRegistry.PrintAllExecurtableFeladat();

            Console.WriteLine("------------------");

            while (true)
            {
                string rawInput = ConsoleView.GetInput();
                FeladatExecuter.ExecuteFeladatMain(rawInput);
                Console.WriteLine(FeladatRegistry.Feladatok.Count);
                Console.WriteLine(FeladatRegistry.FeladatokById.Count);
            }
        }

        private static void InitializeStuff()
        {
            ConsoleView = new ConsoleView();
            FeladatRegistry = new FeladatRegistry();
            FeladatExecuter = new FeladatExecuter();
        }

    }
}
