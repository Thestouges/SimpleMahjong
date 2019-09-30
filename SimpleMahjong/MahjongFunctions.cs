using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMahjong
{
    public class MahjongFunctions
    {
        int ShantenNum;
        public class opentile
        {
            public int total = 0;
            public int closed = 0;
        }
        public int Shanten(List<Tile> hand)
        {
            int result = 0;
            ShantenNum = 8;

            List<opentile> tiles = new List<opentile>(37);
            
            for(int i = 0; i < hand.Count; i++)
            {
                tiles[hand[i].Number].total++;
                if (hand[i].Closed)
                {
                    tiles[hand[i].Number].closed++;
                }
            }

            foreach(opentile item in tiles)
            {
                if(item.total >= 2 && item.closed >=2)
                {

                }
            }

            return result;
        }

        public bool InFuriten(List<Tile> hand, List<Tile> discard)
        {
            bool result = false;

            return result;
        }

        public List<Tile> GetWinningTiles(List<Tile> hand)
        {
            List<Tile> result = new List<Tile>();
            Dictionary<Tile, int> tileList = new Dictionary<Tile, int>();

            foreach(Tile item in hand)
            {
                if(tileList.ContainsKey(item))
                {
                    tileList[item]++;
                }
                else
                {
                    tileList.Add(item, 1);
                }
            }



            return result;
        }
    }
}