using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int Runs { get; set; }
        public int ID { get; set; }

        public Player(string name, int runs, int id)
        {
            Name = name;
            Runs = runs;
            ID = id;
        }

        public int CompareTo(Player other)
        {
            if (other == null)
                return 1;

            return Runs.CompareTo(other.Runs);
        }
    }

    class player2
    {
        static void Main()
        {
            Player player1 = new Player("Virat k", 500, 1);
            Player player2 = new Player("MS dhoni", 600, 2);

            if (player1.CompareTo(player2) > 0)
            {
                Console.WriteLine(player1.Name);
            }
            else if (player1.CompareTo(player2) < 0)
            {
                Console.WriteLine(player2.Name);
            }
            else
            {
                Console.WriteLine("Both players have same number of runs.");
            }
        }
    }
}

