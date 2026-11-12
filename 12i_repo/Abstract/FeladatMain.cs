namespace _12i_repo.Shared
{
    public class FeladatMain
    {
        public virtual void Main() { }



        public FeladatMain()
        {
            Program.FeladatRegistring += RegisterFeladat;
        }

        private void RegisterFeladat()
        {
            Program.FeladatRegistry.AddFeladatMain(Main);
        }

        

        // ide lehetne írni egy .txt file létrehozót amibe beleillesztem az aznapi dátumot.

    }
}
