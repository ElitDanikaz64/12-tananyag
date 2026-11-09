using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12i_repo.Feladatok.GymManager
{
    internal class Program : Shared.FeladatMain
    {
        public Program() : base()
        { }

        public override void Main()
        {
            Member m1 = new Member("John Doe 1", 3, true);
            Member m2 = new Member("John Doe 2", 5, true);
            Member m3 = new Member("John Doe 3", 300, false);

            m2.CheckIn();
            m2.CheckIn();
            m3.CheckIn();
            m3.CheckIn();
            m3.CheckIn();

            Console.WriteLine(m1.Describe());
            Console.WriteLine(m2.Describe());
            Console.WriteLine(m3.Describe());

            Membership ms1 = new Membership(m3, 3, 15);
            Membership ms2 = new Membership(m1, 6, 3);

            Gym gyimesi = new Gym("Gyimesi");

            gyimesi.AddMembership(ms1);
            gyimesi.AddMembership(ms2);

            Console.WriteLine(gyimesi.TotalIncome());
            Console.WriteLine(gyimesi.MostActive().Describe());
        }

    }
}
