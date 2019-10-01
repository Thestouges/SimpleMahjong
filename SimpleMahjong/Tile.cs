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

        public string GetImagePath()
        {
            string path = "";

            switch(Number)
            {
                case 1:
                    path = "~/TileAssets/bamboo/bamboo1.png";
                    break;
                case 2:
                    path = "~/TileAssets/bamboo/bamboo2.png";
                    break;
                case 3:
                    path = "~/TileAssets/bamboo/bamboo3.png";
                    break;
                case 4:
                    path = "~/TileAssets/bamboo/bamboo4.png";
                    break;
                case 5:
                    path = "~/TileAssets/bamboo/bamboo5.png";
                    break;
                case 6:
                    path = "~/TileAssets/bamboo/bamboo6.png";
                    break;
                case 7:
                    path = "~/TileAssets/bamboo/bamboo7.png";
                    break;
                case 8:
                    path = "~/TileAssets/bamboo/bamboo8.png";
                    break;
                case 9:
                    path = "~/TileAssets/bamboo/bamboo9.png";
                    break;
                case 11:
                    path = "~/TileAssets/pin/pin1.png";
                    break;
                case 12:
                    path = "~/TileAssets/pin/pin2.png";
                    break;
                case 13:
                    path = "~/TileAssets/pin/pin3.png";
                    break;
                case 14:
                    path = "~/TileAssets/pin/pin4.png";
                    break;
                case 15:
                    path = "~/TileAssets/pin/pin5.png";
                    break;
                case 16:
                    path = "~/TileAssets/pin/pin6.png";
                    break;
                case 17:
                    path = "~/TileAssets/pin/pin7.png";
                    break;
                case 18:
                    path = "~/TileAssets/pin/pin8.png";
                    break;
                case 19:
                    path = "~/TileAssets/pin/pin9.png";
                    break;
                case 21:
                    path = "~/TileAssets/man/man1.png";
                    break;
                case 22:
                    path = "~/TileAssets/man/man2.png";
                    break;
                case 23:
                    path = "~/TileAssets/man/man3.png";
                    break;
                case 24:
                    path = "~/TileAssets/man/man4.png";
                    break;
                case 25:
                    path = "~/TileAssets/man/man5.png";
                    break;
                case 26:
                    path = "~/TileAssets/man/man6.png";
                    break;
                case 27:
                    path = "~/TileAssets/man/man7.png";
                    break;
                case 28:
                    path = "~/TileAssets/man/man8.png";
                    break;
                case 29:
                    path = "~/TileAssets/man/man9.png";
                    break;

                case 32:
                    path = "~/TileAssets/winds/wind-east.png";
                    break;
                case 33:
                    path = "~/TileAssets/winds/wind-south.png";
                    break;
                case 34:
                    path = "~/TileAssets/winds/wind-west.png";
                    break;
                case 35:
                    path = "~/TileAssets/winds/wind-north.png";
                    break;
                case 36:
                    path = "~/TileAssets/dragons/dragon-chun.png";
                    break;
                case 37:
                    path = "~/TileAssets/dragons/dragon-white.png";
                    break;
                case 38:
                    path = "~/TileAssets/dragons/dragon-green.png";
                    break;
            }

            return path;
        }
    }
}
