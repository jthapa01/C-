using System;
using System.Collections.Generic;
using System.Text;
using Bets;
using Player;

namespace Player
{
    public class Player : IPlayer
    {
        public Player(string name, long cash)
        {
            Name = name;
            Cash = cash;
        }

        public ICollection<IBet> Bets { get; set; }
        public long Cash {get; set;}

        public string Name {get;}
        //public IPlayingSystem system { get; set; }
    }
}
