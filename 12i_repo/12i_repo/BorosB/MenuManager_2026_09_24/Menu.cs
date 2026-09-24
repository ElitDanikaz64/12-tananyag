namespace _12i_repo.BorosB.MenuManager_2026_09_24
{
    // 2.) Rename manually class
    public class Menu : Shared.ProgramStartManager
    {
        // -- Feladat torso --

        public string Name { get; set; }

        public List<MenuItem> Items
        {
            get { return _items; }
        }

        private List<MenuItem> _items;

        public Menu(string etlapName)
        {
            Name = etlapName;
            _items = new List<MenuItem>();
        }

        public MenuItem FindByName(string targetName)
        {
            return _items.Where(x => x.Name == targetName).First();
        }

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
        }

        public List<MenuItem> AvalibleItems()
        {
            return _items.Where(x => x.IsAvalible).ToList();
        }

        public List<MenuItem> ItemsByCategory(string targetCategory)
        {
            return _items.Where(x => x.Name == targetCategory).ToList();
        }

        public double AveragePrice(string targetCategory)
        {
            return _items.Where(x => x.Name == targetCategory).Average(x => x.Price);
        }

        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            // MenuItem-ben van a kiirási megoldás
        }
    }
}
