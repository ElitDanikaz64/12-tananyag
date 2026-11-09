using System.Linq;
using System.Reflection;

namespace _12i_repo
{
    internal class FeladatRegistry
    {

        internal Dictionary<Type, Shared.FeladatMain> Feladatok { get; private set; }
        internal Dictionary<string, Action> FeladatokById { get; private set; }

        internal FeladatRegistry()
        {
            Feladatok = new Dictionary<Type, Shared.FeladatMain>();
            FeladatokById = new Dictionary<string, Action>();

            InstFeladatClasses();

        }

        internal void InstFeladatClasses()
        {
            List<Type> foundTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && 
            !t.IsAbstract && 
            !t.IsInterface &&
            t.IsSubclassOf(typeof(Shared.FeladatMain))).ToList();

            List<Shared.FeladatMain> list = new List<Shared.FeladatMain>();

            foreach (Type t in foundTypes)
            {
                Shared.FeladatMain instanciatedFeladat = Activator.CreateInstance(t) as Shared.FeladatMain;

                if (instanciatedFeladat == null)
                    continue;

                Feladatok.Add(t, instanciatedFeladat);
                AddFeladatMain(instanciatedFeladat.Main);
            }

        }

        internal void AddFeladatMain(Action feladatMain)
        {
            if (feladatMain == null)
            {
                Program.ConsoleView.Error("AddFeladatMain() null-t kapott argumentumként.");
                Console.WriteLine("1");
                return;
            }
            if (feladatMain.Method.DeclaringType == null)
            {
                Program.ConsoleView.Error("AddFeladatMain() nem tudta beazonosítani a deklaráló típust (null volt).");
                Console.WriteLine("2");
                return;
            }
            if (string.IsNullOrEmpty(feladatMain.Method.DeclaringType.Namespace))
            {
                Program.ConsoleView.Error("AddFeladatMain() nem tudta beazonosítani a deklaráló típus namespace-jét (null volt).");
                Console.WriteLine("3");
                return;
            }

            if (Feladatok.ContainsKey(feladatMain.Method.DeclaringType))
            {
                Program.ConsoleView.Warn("AddFeladatMain() nem sikerült, mert már létezik ez a registry-ben.");
                Console.WriteLine("4");
                return;
            }

            Console.WriteLine($"elérte, feladatMain.Method.DeclaringType={feladatMain.Method.DeclaringType}, feladatMain={feladatMain}");

            FeladatokById.Add(feladatMain.Method.DeclaringType.Namespace!.Split('.')[^1], feladatMain);

        }

        internal void PrintAllExecurtableFeladat()
        {
            foreach (var pair in FeladatokById) 
            {
                Program.ConsoleView.Message(pair.Key);
            }
        }
    }
}
