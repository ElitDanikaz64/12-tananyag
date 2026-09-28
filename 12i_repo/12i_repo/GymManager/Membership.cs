namespace _12i_repo.GymManager
{
    public class Membership : Shared.OraiFeladat
    {
        // -- Feladat torso --

        private string _owner;
        private int _monthlyPrice;
        private int _months;

        public string Owner
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

        public Membership(string owner, int monthlyPrice, int months, bool isStudent /*ez itt extra*/)
        {
            _owner = owner;
            _monthlyPrice = monthlyPrice;
            _months = months;
            _isStudent = isStudent;
        }

        public int TotalCost()
        {
            return _isStudent ? Convert.ToInt32(Math.Round(.8 * (MonthlyPrice * Months))) : MonthlyPrice * Months;
        }

        public void Extend(int months)
        {
            Months += months;
        }

        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {

        }
    }
}
