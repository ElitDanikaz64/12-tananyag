namespace _12i_repo
{
    internal class Program
    {

        public static event Action FeladatMeghivas = new ;

        static void Main(string[] args)
        {
            FeladatMeghivas?.Invoke();
        }
    }
}
