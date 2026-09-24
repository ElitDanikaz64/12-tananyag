namespace _12i_repo.Shared
{
    public class ProgramStartManager
    {
        public virtual void OnProgramStart() { }

        public ProgramStartManager()
        {
            Program.FeladatMeghivas += OnProgramStart;
        }
    }
}
