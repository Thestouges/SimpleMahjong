using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMahjong
{
    /*
     * 0
     * 1    1 Bamboo
     * 2    2 Bamboo
     * 3    3 Bamboo
     * 4    4 Bamboo
     * 5    5 Bamboo
     * 6    6 Bamboo
     * 7    7 Bamboo
     * 8    8 Bamboo
     * 9    9 Bamboo
     * 10
     * 11   1 Dots
     * 12   2 Dots
     * 13   3 Dots
     * 14   4 Dots
     * 15   5 Dots
     * 16   6 Dots
     * 17   7 Dots
     * 18   8 Dots
     * 19   9 Dots
     * 20
     * 21   1 Character
     * 22   2 Character
     * 23   3 Character
     * 24   4 Character
     * 25   5 Character
     * 26   6 Character
     * 27   7 Character
     * 28   8 Character
     * 29   9 Character
     * 30
     * 31
     * 32   East Wind
     * 33   South Wind
     * 34   West Wind
     * 35   North Wind
     * 36   Red Dragon
     * 37   White Dragon
     * 38   Green Dragon
     */

    public enum Suit
    {
        Bamboo = 0,
        Dots = 1,
        Character = 2,
        Wind = 3,
        Dragon = 4
    }
    public class Tile
    {
        public int Number;
        public bool Closed = true;
    }
}