namespace _12i_repo.BorosB.Ora_2026_09_17
{
    public class Librarian : Shared.ProgramStartManager
    {
        // -- Feladat torso --

        public string Name { get; set; }
        private Library _library;

        public Librarian(string name, Library library)
        {
            Name = name;
            _library = library;
        }

        public void Introduce()
        {
            Console.WriteLine($"Nevem, {Name} és a {_library.Name} könyvtárban dolgozom.");
        }



        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {

        }
    }
}
