using System;
using System.Collections.Generic;
using System.Text;
using Bets;
namespace Player
{
    public interface IPlayer
    {
        ICollection<IBet> Bets { get; set; }
        long Cash { get; set; }
        string Name { get; }
        //IPlayingSystem System { get; set; }
    }
}
