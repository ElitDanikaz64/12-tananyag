namespace _12i_repo.Shared
{
    public class OraiFeladat
    {
        public virtual void Main() { }

        public OraiFeladat()
        {
            Program.FeladatMeghivas += Main;
        }

        // ide lehetne írni egy .txt file létrehozót amibe beleillesztem az aznapi dátumot.

    }
}
