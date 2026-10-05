namespace _12i_repo.Feladatok.GymManager
{
    public class Membership : Shared.OraiFeladat
    {
        // -- Feladat torso --

        private Member _owner;
        private int _monthlyPrice;
        private int _months;

        public Member Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        public int MonthlyPrice
        {
            get { return _monthlyPrice; }
            set { _monthlyPrice = value; }
        }
        public int Months
        {
            get { return _months; }
            set { _months = value; }
        }

        private bool _isStudent;

        public Membership(Member owner, int monthlyPrice, int months)
        {
            _owner = owner;
            _monthlyPrice = monthlyPrice;
            _months = months;
            _isStudent = owner.IsStudent;
        }

        public int TotalCost()
        {
            return _isStudent ? Convert.ToInt32(Math.Round(.8 * (MonthlyPrice * Months))) : MonthlyPrice * Months;
        }

        public void Extend(int months)
        {
            Months += months;
        }

        public int PricePerVisit()
        {
            if(_owner.GetVisits() == 0)
                return TotalCost();
            else 
                return (int)(TotalCost() / _owner.GetVisits());
        } 

        // -- Main-be kerülő logika --

        public override void Main()
        {
            // member.cs-ben van a Main.cs-es/példányosításos feladatok megoldása
        }
    }
}
