namespace _12i_repo.Shared
{
    public class OraiFeladat
    {
        public virtual void OnProgramStart() { }

        public OraiFeladat()
        {
            Program.FeladatMeghivas += OnProgramStart;
        }

        // ide lehetne írni egy .txt file létrehozót amibe beleillesztem az aznapi dátumot.

    }
}
