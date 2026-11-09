namespace _12i_repo.Feladatok.GymManager // 1.) Relocate 
{
    public class Member
    {
        // -- Feladat torso --

        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public bool IsStudent
        {
            get { return _isStudent; }
            set { _isStudent = value; }
        }
        public int Visits
        {
            get { return _visits; }
            set { _visits = value; }
        }

        public Member(string name, int age, bool isStudent)
        {
            _name = name;
            _age = age;
            _isStudent = isStudent;
        }


        public void CheckIn()
        {
            _visits++;
        }

        public string Describe()
        {
            return IsStudent ? $"{Name} ({Age} éves diák)" : $"{Name} ({Age} éves normál)";
        }

        public int GetVisits()
        {
            return _visits;
        }
    }
}
