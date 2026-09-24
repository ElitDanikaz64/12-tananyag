namespace _12i_repo.BorosB.OsztalyMetodusGyakorlas.Ora_2026_09_17
{
    public class Librarian : Shared.OraiFeladat
    {
        // -- Feladat torso --

        public string Name { get; set; }
        private Library _library;
        public int LentCount { get; set; }

        public Librarian(string name, Library library)
        {
            Name = name;
            _library = library;
        }

        public void Introduce()
        {
            Console.WriteLine($"Nevem, {Name} és a {_library.Name} könyvtárban dolgozom.");
        }

        public void AddBook(string title, string author, int pageCount)
        {
            Book newBook = new Book(title, author, pageCount);
            _library.AddBooks(newBook);
        }

        public void LendBook(string title)
        {
            Book targetBook = _library.FindByTitle(title);

            targetBook.Borrow();

            if (targetBook.IsAvalible) LentCount++;
        }

        public void TakeBack(string title)
        {
            Book targetBook = _library.FindByTitle(title);

            targetBook.Return();
        }

        public void Report()
        {
            Console.WriteLine($"Könyvtár neve: {Name}\nKönyvek száma: {_library.BookCount}\n");
        }

        /*public Book Recommend(int maxPageCount) // kicsi paradoxon, mert a _library osztályának a List<Book> mezőjéből kellene szerintem keresni, de az feladat szerint privát
        {
        }*/

        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {

        }
    }
}
