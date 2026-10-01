namespace _12i_repo.Feladatok.GymManager // 1.) Relocate 
{
    // 2.) Rename manually class
    public class Gym : Shared.OraiFeladat
    {
        // -- Feladat torso --

        private string _name;
        private List<Membership> _memberships;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Membership> Memberships
        {
            get { return _memberships; }
            set { _memberships = value; }
        }

        public Gym(string name)
        {
            _name = name;
            _memberships = new List<Membership>();
        }


        public void AddMembership(Membership newMbship)
        {
            _memberships.Add(newMbship);
        }

        public int TotalIncome()
        {
            return _memberships.Sum(x => x.TotalCost());
        }

        public Member MostActive()
        {
            return _memberships.OrderByDescending(x => x.Owner.GetVisits()).Select(x=>x.Owner).First();
        }

        public Membership BestValue()
        {
            return _memberships.OrderBy(x => x.PricePerVisit()).Select(x => x).First();
        }


        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            // member.cs-ben van a Main.cs-es/példányosításos feladatok megoldása
        }
    }
}
