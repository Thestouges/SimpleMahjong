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

            int index = 0;
            foreach(opentile item in tiles)
            {
                if(item.total >= 2 && item.closed >=2)
                {
                    List<opentile> temptiles = tiles;
                    temptiles[index].total -= 2;
                    ShantenNumber(temptiles, ref ShantenNum);
                }
                index++;
            }

            return result;
        }

        public void ShantenNumber(List<opentile> tiles, ref int shantenNum)
        {
            int tempShanten = shantenNum;

            for(int i = 0; i < tiles.Count; i++)
            {
                //check pons and pairs
                if (tiles[i].total >= 3)
                {
                    List<opentile> temptiles = tiles;
                    temptiles[i].total -= 3;
                    tempShanten -= 2;
                    ShantenNumber(temptiles, ref tempShanten);
                    tempShanten = shantenNum;
                }
                if (tiles[i].total >= 2)
                {
                    List<opentile> temptiles = tiles;
                    temptiles[i].total -= 3;
                    tempShanten -= 1;
                    ShantenNumber(temptiles, ref tempShanten);
                    tempShanten = shantenNum;
                }

                if (i >= 30)
                    continue;

                //check sequences
                if (tiles[i].total >= 1)
                {
                    if(tiles[i+1].total >= 1 && tiles[i+2].total >= 1)
                    {
                        List<opentile> temptiles = tiles;
                        temptiles[i].total -= 1;
                        temptiles[i+1].total -= 1;
                        temptiles[i+2].total -= 1;
                        tempShanten -= 2;
                        ShantenNumber(temptiles, ref tempShanten);
                        tempShanten = shantenNum;
                    }
                    else if (tiles[i + 1].total >= 1)
                    {
                        List<opentile> temptiles = tiles;
                        temptiles[i].total -= 1;
                        temptiles[i + 1].total -= 1;
                        tempShanten -= 1;
                        ShantenNumber(temptiles, ref tempShanten);
                        tempShanten = shantenNum;
                    }
                    else if (tiles[i + 2].total >= 1)
                    {
                        List<opentile> temptiles = tiles;
                        temptiles[i].total -= 1;
                        temptiles[i + 2].total -= 1;
                        tempShanten -= 1;
                        ShantenNumber(temptiles, ref tempShanten);
                        tempShanten = shantenNum;
                    }
                }
            }

            if (ShantenNum < tempShanten)
            {
                shantenNum = tempShanten;
            }
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