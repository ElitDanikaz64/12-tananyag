namespace _12i_repo.BorosB.Ora_2026_09_17
{
    public class Library : Shared.ProgramStartManager
    {
        // -- Feladat torso --

        public string Name { get; set; }
        private List<Book> _books;
        public int BookCount { get { return _books.Count; } }

        public Library(string name)
        {
            Name = name;

            _books = new List<Book>();
        }

        public void AddBooks(Book book)
        {
            if (!_books.Contains(book))
            {
                _books.Add(book); 
                return;
            }
            Console.WriteLine($"Ez a könyv már eleve létezik!");
        }

        public void PrintAll()
        {
            _books.ForEach(x => x.Description());
        }

        public Book FindByTitle(string targetTitle)
        {
            return _books.Where(x => x.Title == targetTitle).Select(x=>x).First();
        }

        public List<Book> FindByAuthor(string targetAuthor)
        {
            return _books.Where(x => x.Author == targetAuthor).Select(x=>x).ToList();
        }

        public int TotalPages() 
        {
            if (_books.Count == 0) return 0;
            return _books.Sum(x => x.PageCount);
        }

        public double AveragePages()
        {
            if (_books.Count == 0) return 0;
            return _books.Average(x => x.PageCount);
        }

        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            Library Konyvtar = new Library("Széchenyi Könyvtár");
            Konyvtar.AddBooks(new Book("a", "b"));
            Konyvtar.AddBooks(new Book("c", "d"));
            Konyvtar.AddBooks(new Book("d", "f"));
            Konyvtar.AddBooks(new Book("e", "h"));
            Konyvtar.AddBooks(new Book("f", "n"));

            if (Konyvtar.FindByTitle("q") == null)
                Console.WriteLine($"Sajnos ilyen nem volt :(");
        }
    }
}
