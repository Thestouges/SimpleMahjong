using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMahjong
{
    public class MahjongFunctions
    {
        int ListNumber;
        int ShantenNum = 8;

        public MahjongFunctions()
        {
            ListNumber = 39;
        }
        public class opentile
        {
            public int total = 0;
            public int closed = 0;

            public opentile Copy()
            {
                return new opentile { total = this.total, closed = this.closed };
            }
        }
        public int Shanten(List<Tile> hand)
        {
            ShantenNum = 8;

            List<opentile> tiles = new List<opentile>();
            for (int i = 0; i < ListNumber; i++)
            {
                opentile opentile = new opentile();
                tiles.Add(opentile);
            }

            
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
                int tempShantenNum = 8;
                if (item.total >= 2 && item.closed >=2)
                {
                    List<opentile> temptiles = tiles.Select(x => x.Copy()).ToList();
                    temptiles[index].total -= 2;
                    //temptiles[index].closed -= 2;
                    ShantenNumber(temptiles, ref tempShantenNum, 1);
                }
                if(item.total == 1 && item.closed >= 1)
                {
                    List<opentile> temptiles = tiles.Select(x => x.Copy()).ToList();
                    temptiles[index].total -= 1;
                    tempShantenNum++;
                    //temptiles[index].closed -= 2;
                    ShantenNumber(temptiles, ref tempShantenNum, 1);
                }
                index++;

                if (ShantenNum > tempShantenNum)
                {
                    ShantenNum = tempShantenNum;
                }
            }

            SevenPairsShanten(tiles.Select(x => x.Copy()).ToList());
            ThirteenOrphansShanten(tiles.Select(x => x.Copy()).ToList());

            return ShantenNum;
        }

        public void ShantenNumber(List<opentile> tiles, ref int shantenNum, int counter)
        {
            int baseShanten = shantenNum;
            int tempShanten = shantenNum;

            for (int i = counter; i < tiles.Count-1; i++)
            {
                //check pons and pairs
                if (tiles[i].total >= 3)
                {
                    List<opentile> temptiles = tiles.Select(x => x.Copy()).ToList();
                    temptiles[i].total -= 3;
                    tempShanten -= 2;
                    ShantenNumber(temptiles, ref tempShanten, i);
                    tempShanten = baseShanten;
                }
                if (tiles[i].total >= 2)
                {
                    List<opentile> temptiles = tiles.Select(x => x.Copy()).ToList();
                    temptiles[i].total -= 2;
                    tempShanten -= 1;
                    ShantenNumber(temptiles, ref tempShanten, i);
                    tempShanten = baseShanten;
                }

                if (i >= 30)
                    continue;

                if (i % 10 == 9)
                    continue;

                //check sequences
                if (tiles[i].total >= 1)
                {
                    if(tiles[i+1].total >= 1 && tiles[i+2].total >= 1)
                    {
                        List<opentile> temptiles = tiles.Select(x => x.Copy()).ToList();
                        temptiles[i].total -= 1;
                        temptiles[i+1].total -= 1;
                        temptiles[i+2].total -= 1;
                        tempShanten -= 2;
                        ShantenNumber(temptiles, ref tempShanten, i);
                        tempShanten = baseShanten;
                    }
                    else if (tiles[i + 1].total >= 1)
                    {
                        List<opentile> temptiles = tiles.Select(x => x.Copy()).ToList();
                        temptiles[i].total -= 1;
                        temptiles[i + 1].total -= 1;
                        tempShanten -= 1;
                        ShantenNumber(temptiles, ref tempShanten, i);
                        tempShanten = baseShanten;
                    }
                    else if (tiles[i + 2].total >= 1)
                    {
                        List<opentile> temptiles = tiles.Select(x => x.Copy()).ToList();
                        temptiles[i].total -= 1;
                        temptiles[i + 2].total -= 1;
                        tempShanten -= 1;
                        ShantenNumber(temptiles, ref tempShanten, i);
                        tempShanten = baseShanten;
                    }
                }
            }

            if (ShantenNum > tempShanten)
            {
                ShantenNum = tempShanten;
            }
        }

        private void SevenPairsShanten(List<opentile> tiles)
        {
            int sp_shanten = 7;

            foreach(opentile item in tiles)
            {
                if(item.total >= 2 && item.closed >= 2)
                {
                    sp_shanten--;
                }
            }

            if(ShantenNum > sp_shanten)
            {
                ShantenNum = sp_shanten;
            }
        }

        private void ThirteenOrphansShanten(List<opentile> tiles)
        {
            int to_shanten = 14;
            bool pair = false;

            for (int i = 0; i < tiles.Count; i++)
            {
                if(i > 30 || i % 10 == 1 || i % 10 == 9)
                {
                    if(tiles[i].total == 2 && pair == false)
                    {
                        to_shanten -= 2;
                        pair = true;
                    }
                    else if(tiles[i].total >= 1)
                    {
                        to_shanten--;
                    }
                }
            }

            if(ShantenNum > to_shanten)
            {
                ShantenNum = to_shanten;
            }
        }

        public bool InFuriten(List<Tile> discard, List<Tile> winningTiles)
        {
            foreach(Tile dis in discard)
            {
                foreach(Tile wt in winningTiles)
                {
                    if (dis == wt)
                        return true;
                }
            }

            return false;
        }

        public List<Tile> GetWinningTiles(List<Tile> hand)
        {
            List<Tile> result = new List<Tile>();

            for(int i = 0; i < ListNumber; i++)
            {
                if (i % 10 == 0)
                {
                    continue;
                }
                List<Tile> temptiles = hand.Select(x => x.Copy()).ToList();

                Tile tile = new Tile();
                tile.Number = i;
                tile.Closed = false;
                temptiles.Add(tile);

                if(Shanten(temptiles) == 0)
                {
                    result.Add(tile);
                }
            }
            
            return result;
        }
    }
}