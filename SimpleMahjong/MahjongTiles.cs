using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMahjong
{
    public class MahjongTiles
    {
        List<Tile> MahjongSet;

        public MahjongTiles()
        {
            InitializeSet();
        }

        private void InitializeSet()
        {
            AddTiles();
            ShuffleSet();
        }

        public void AddTiles()
        {
            for (int i = 0; i < 38; i++)
            {
                if (i % 10 != 0)
                {
                    for(int j = 0; j < 4; j++)
                    {
                        Tile Tile = new Tile();
                        Tile.Number = i;
                        MahjongSet.Add(Tile);
                    }
                }
            }
        }

        public void ShuffleSet()
        {
            Random rnd = new Random();
            var result = MahjongSet.OrderBy(item => rnd.Next());
            MahjongSet = result.ToList();
        }

        public Tile DrawTile()
        {
            Tile Draw = MahjongSet[MahjongSet.Count-1];
            MahjongSet.RemoveAt(MahjongSet.Count - 1);

            return Draw;
        }

        public int GetTilesCount()
        {
            return MahjongSet.Count;
        }
    }
}