

namespace _12i_repo.Feladatok.KozossegiOldal // Relocate 
{ 
    public class Program : _12i_repo.Abstract.FeladatMain
    {

        // A konstruktor invokáció ne futtasson kódot kivétel az inheritált konstruktor.
        public Program() : base() { }


        // Feladat lefuttatására szolgáló rész
        public override void Main()
        {
            TextPost tp = new TextPost("John Doe", "123456789a123456789a123");
            ImagePost ip1 = new ImagePost("John Doe1", 5);
            ImagePost ip2 = new ImagePost("John Doe2", 6);
            ImagePost ip3 = new ImagePost("John Doe3", 7);
        }
    }
}
