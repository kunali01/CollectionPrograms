using FirstDemo1;
using System;
using System.Collections;
namespace FirstDemo1
{
    public class Player : IComparable
    {
        private int runs;
        private string name;
        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public int Runs
        {
            get { return runs; }
        }
        public int CompareTo(object obj) // obj = virat
        {
            // runs of virat is in the obj object, need typecasting to get data
            Player p1 = (Player)obj; // virat's object assign to p1
            // this points to current object ie. object of rohit
            if (this.runs > p1.runs)
            {
                return 1;
            }
            else if (this.runs < p1.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $" Name={name} , Runs= {runs}";
        }
    }

    public class Team : IEnumerable
    {
        Player[] player;
        public Team()
        {
            player = new Player[3];
            player[0] = new Player(100, "Virat");
            player[1] = new Player(50, "Rohit");
            player[2] = new Player(25, "MS-Dhoni");
        }

        public IEnumerator GetEnumerator()
        {
            return player.GetEnumerator();
        }
    }
    public class CheckRuns : IComparer
    {
        public int Compare(object x, object y)
        {
            Player p1 = (Player)x;
            Player p2 = (Player)y;
            if (p1.Runs > p2.Runs)
            {
                return 1;
            }
            else if (p1.Runs < p2.Runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        //static void Main(string[] args)
        //{
        //    ////  Array
        //    //  int[] arr = new int[] { 1, 2, 3, 4, 5 };
        //    ////  IEnumerable
        //    //  foreach (var item in arr)
        //    //  {
        //    //      Console.WriteLine(item); //1  2   3  4  5
        //    //  }

        //    //  Team india = new Team();
        //    //  foreach (Player p in india)
        //    //  {
        //    //      Console.WriteLine(p);
        //    //  }

        //    Player rohit = new Player(80, "Rohit");
        //    Player virat = new Player(20, "Virat");
        //    // object with call  --> parameter
        //    //int result=rohit.CompareTo(virat);
        //    CheckRuns c1 = new CheckRuns();
        //    int result = c1.Compare(rohit, virat);
        //    if (result == 1)
        //    {
        //        Console.WriteLine("Rohit scored more runs than virat");
        //    }
        //    else if (result == -1)
        //    {
        //        Console.WriteLine("Virat scored more runs than Rohit");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Both scored equal");
        //    }
        //}
    }
}
