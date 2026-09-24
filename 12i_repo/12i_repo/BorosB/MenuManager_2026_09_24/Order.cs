namespace _12i_repo.BorosB.MenuManager_2026_09_24
{
    public class Order : Shared.ProgramStartManager
    {
        // -- Feladat torso --

        private List<MenuItem> _items;
        
        public int ItemCount
        {
            get { return _items.Count; }
        }

        public Order()
        {
            _items = new List<MenuItem>();
        }

        public bool Add(MenuItem item)
        {
            if (!item.IsAvalible) return false;

            _items.Add(item);

            return _items.Contains(item);
        }

        public int Total()
        {
            return _items.Sum(x => x.Price);
        }

        public string GetSummary()
        {
            return $"Tételek száma: {_items.Count}, Végösszeg: {Total()}";
        }

        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            // MenuItem-ben van a kiirási megoldás
        }
    }
}
