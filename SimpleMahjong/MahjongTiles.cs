using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMahjong
{
    public class MahjongTiles
    {
        List<Tile> MahjongSet;

        MahjongTiles()
        {
            InitializeSet();
        }

        private void InitializeSet()
        {
            AddWindTile();
            AddDragonTile();
        }

        private void AddWindTile()
        {
            Tile WindTile = new Tile();
            WindTile.Suit = Suit.Wind;
            WindTile.Terminal = true;

            WindTile.Letter = "EAST";
            MahjongSet.Add(WindTile);

            WindTile.Letter = "SOUTH";
            MahjongSet.Add(WindTile);

            WindTile.Letter = "NORTH";
            MahjongSet.Add(WindTile);

            WindTile.Letter = "SOUTH";
            MahjongSet.Add(WindTile);
        }

        private void AddDragonTile()
        {
            Tile DragonTile = new Tile();
            DragonTile.Suit = Suit.Dragon;
            DragonTile.Terminal = true;

            DragonTile.Letter = "RED";
            MahjongSet.Add(DragonTile);

            DragonTile.Letter = "GREEN";
            MahjongSet.Add(DragonTile);

            DragonTile.Letter = "WHITE";
            MahjongSet.Add(DragonTile);
        }

        private void AddNumberTile()
        {
            for (int j = 1; j <= 3; j++)
            {
                Suit suit = new Suit();
                suit = (Suit)j;
                for (int i = 1; i <= 9; i++)
                {
                    Tile NumberTile = new Tile();
                    NumberTile.Suit = suit;

                    if (i == 1 || i == 9)
                    {
                        NumberTile.Terminal = true;
                    }
                    else
                    {
                        NumberTile.Terminal = false;
                    }

                    NumberTile.Letter = i.ToString();
                    MahjongSet.Add(NumberTile);
                }
            }
        }
    }
}