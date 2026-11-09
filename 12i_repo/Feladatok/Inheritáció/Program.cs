namespace _12i_repo.Feladatok.Inherit
{
    internal class Program : Shared.FeladatMain
    {

        public Program() : base()
        { }

        public override void Main()
        {
            Movie m1 = new Movie("John Doe movie", 2024, 128);
            Console.WriteLine(m1.GetDescription());


            Series s1 = new Series("John Doe series", 2022, 10, 45);
            Console.WriteLine(s1.GetDescription());


            Game g = new Game("Scrap Mechanic", 1500);


            Phone p = new Phone(12000);

            p.Download(m1);
            Console.WriteLine(p.FreeMbSpace);
            p.Download(g);
            Console.WriteLine(p.FreeMbSpace);


            Phone p2 = new Phone(20000);

            p2.IsWifiOn = false;

            p2.Download(m1);
            Console.WriteLine(p2.FreeMbSpace);

            p2.IsWifiOn = true;

            p2.Download(m1);
            Console.WriteLine(p2.FreeMbSpace);
        }
    }
}
