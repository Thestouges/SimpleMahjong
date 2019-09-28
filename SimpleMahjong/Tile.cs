using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMahjong
{
    public enum Suit
    {
        Bamboo = 1,
        Dots = 2,
        Character = 3,
        Wind = 4,
        Dragon = 5
    }
    public class Tile
    {
        public Suit Suit;
        public string Letter;
        public bool Terminal;
    }
}