namespace _12i_repo.GymManager // 1.) Relocate 
{
    public class Member : Shared.OraiFeladat
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

        // -- Main-be kerülő logika --

        public override void OnProgramStart()
        {
            Member m1 = new Member("John Doe 1", 3, true);
            Member m2 = new Member("John Doe 2", 5, true);
            Member m3 = new Member("John Doe 3", 300, false);

            m1.CheckIn();
            m2.CheckIn();
            m2.CheckIn();
            m3.CheckIn();
            m3.CheckIn();
            m3.CheckIn();

            Console.WriteLine(m1.Describe());
            Console.WriteLine(m2.Describe());
            Console.WriteLine(m3.Describe());

        }
    }
}
