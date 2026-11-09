using _12i_repo.Ora_2026_09_17;

namespace _12i_repo.Feladatok.Ora_2026_09_17
{
    internal class Program : Shared.FeladatMain
    {
        public Program() : base()
        {
            Library Konyvtar = new Library("Széchenyi Könyvtár");
            Konyvtar.AddBooks(new Book("a", "b"));
            Konyvtar.AddBooks(new Book("c", "d"));
            Konyvtar.AddBooks(new Book("d", "f"));
            Konyvtar.AddBooks(new Book("e", "h"));
            Konyvtar.AddBooks(new Book("f", "n"));

            if (Konyvtar.FindByTitle("q") == null)
                Console.WriteLine($"Sajnos ilyen nem volt :(");

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
