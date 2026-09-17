namespace _12i_repo.Shared
{
    public class OraiFeladat
    {
        public virtual void OnProgramStart() { }

        public OraiFeladat()
        {
            Program.FeladatMeghivas += OnProgramStart;
        }
    }
}
