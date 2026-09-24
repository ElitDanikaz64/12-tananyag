namespace _12i_repo.BorosB.MenuManager_2026_09_24 
{
    public class MenuItem : Shared.ProgramStartManager
    {
        // -- Feladat torso --

        public string Name { get; set; }
        public string Category { get; set; }
        public int Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    _price = 0;
                    return;
                }
                _price = value;
            }
        }

        public bool IsAvalible { get; set; }
        public static int Count;
        private int _price;


        public void SellOut()
        {
            IsAvalible = false;
        }
        public void Restock()
        {
            IsAvalible = true;
        }

        public string GetDiscription()
        {
            return $"Tétel neve {Name}, kategóriája {Category} és ára {Price} Ft";
        }


        public MenuItem(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
            IsAvalible = true;

            Count++;
        }


        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            MenuItem menuItem1 = new MenuItem("Rántotthús", "kajcsi", 1500);
            MenuItem menuItem2 = new MenuItem("Víz", "ital", 400);

            ConsoleView consoleView = new ConsoleView();

            consoleView.ShowItem(menuItem1);
            consoleView.ShowItem(menuItem2);

            MenuItem menuItem3 = new MenuItem("1", "zaba", 20);
            MenuItem menuItem4 = new MenuItem("2", "pia", 3000);
            MenuItem menuItem5 = new MenuItem("3", "hamihami", 45500);

            List<MenuItem> lista = new List<MenuItem>() { menuItem1, menuItem2, menuItem3, menuItem4, menuItem5 };

            consoleView.ShowItems(lista);

            menuItem4.SellOut();

            Order newOrder = new Order();

            newOrder.Add(menuItem1);
            newOrder.Add(menuItem2);
            newOrder.Add(menuItem3);
            newOrder.Add(menuItem4);
            newOrder.Add(menuItem5);

            consoleView.ShowMessage(newOrder.GetSummary());

        }
    }
}
