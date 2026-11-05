namespace _12i_repo.Core
{
    internal class ConsoleView
    {
        internal string GetInput()
        {
            string? rawInput = Console.ReadLine();

            while (string.IsNullOrEmpty(rawInput))
            {
                rawInput = Console.ReadLine();
            }

            return rawInput;
        }

        internal void Message(string message)
        {
            Console.WriteLine(message);
        }

        internal void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(message);

            Console.ResetColor();
        }
        internal void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);

            Console.ResetColor();
        }

    }
}
