namespace _12i_repo
{
    internal class Program
    {

        public static event Action FeladatMeghivas;

        static void Main(string[] args)
        {
            FeladatMeghivas?.Invoke();
        }
    }
}
