using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player (string name, int score)
        {
            Name = name;
            Score = score;
        }
        public int CompareTo(Player howeverIwant)
        {
            if (howeverIwant == null)
            {
                return 1;
            }
            return this.Score.CompareTo(howeverIwant.Score);
        }
    }
}