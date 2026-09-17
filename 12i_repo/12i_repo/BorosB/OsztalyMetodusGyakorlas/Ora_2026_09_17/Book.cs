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


        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }


        public void Description()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, PageC.: {PageCount}");
        }

        public bool IsLong()
        {
            return PageCount > 300;
        }

        // -- interface stuff --

        public override void OnProgramStart()
        {
            Book book1 = new Book("a", "John Doe v1", 60);
            Book book2 = new Book("b", "John Doe v2", 40);

            book1.Description();
            book2.Description();

            Console.WriteLine(book1.IsLong());
            Console.WriteLine(book2.IsLong());


        }
    }
}
