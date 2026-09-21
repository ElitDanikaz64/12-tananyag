namespace _12i_repo.BorosB.OsztalyMetodusGyakorlas.Ora_2026_09_17
{
    public class Book : Shared.OraiFeladat
    {
        // -- Feladat torso --
        
        public string Title { get; set; }
        public string Author { get; set; }

        private int _pageCount;
        public int PageCount {
            get 
            {
                return _pageCount;
            }
            set 
            {
                if (value < 0)
                {
                    _pageCount = 0;
                    return;
                }
                _pageCount = value;
            }
        }

        public static int BookCount = 0;
        public bool IsAvalible { get; set; }

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;

            BookCount++;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            PageCount = 0;

            BookCount++;
        }

        public void Description()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, PageC.: {PageCount}");
        }

        public bool IsLong()
        {
            return PageCount > 300;
        }

        public void Borrow()
        {
            if (IsAvalible)
            {
                Console.WriteLine($"Már kivetted a(z) {this.Title} című könyvet!");
                return;
            }

            IsAvalible = false;
        }

        public void Return()
        {
            if (IsAvalible)
            {
                Console.WriteLine($"Már visszavitted a(z) {this.Title} című könyvet!");
                return;
            }

            IsAvalible = true;
        }

        public string ShortTitle(int maxLength)
        {
            if (Title.Length <= maxLength) return Title;

            string shortTitle = "";

            for (int i = 0; i < Title.Length; i++)
            {
                char c = Title[i];

                if (i + 1 > maxLength)
                    c = '.';

                shortTitle += c;
            }

            return shortTitle;
        }

        public bool SameAuthor(Book other)
        {
            return this == other;
        }

        public int ReadingDays(int pagesPerDay)
        {
            return PageCount * pagesPerDay;
        }

        

        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            Book book1 = new Book("a", "John Doe v1", 60);
            Book book2 = new Book("b", "John Doe v2", 40);

            book1.Description();
            book2.Description();

            Console.WriteLine(book1.IsLong());
            Console.WriteLine(book2.IsLong());

            Book book3 = new Book("c", "John Doe v2");

            Console.WriteLine($"{Book.BookCount} db könyv lett létrehozva idáig.");
        }
    }
}
