using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMahjong
{
    public class MahjongGame
    {
        class PlayerHand
        {
            public List<Tile> Hand;
            public List<Tile> Discard;
            public Tile drawn;
            public List<Tile> WinningTiles;
        }

        class DoraIndicators
        {
            public List<Tile> DoraIndicator;
        }

        MahjongTiles GameSet;
        List<PlayerHand> Players;
        int playerCount = 4;
        DoraIndicators doraIndicators;
        MahjongFunctions MahjongFunctions;
        int currTurn = 0;

        MahjongGame()
        {
            GameSet = new MahjongTiles();
            doraIndicators = new DoraIndicators();
            InitializeGame();
        }

        public void InitializeGame()
        {
            for (int i = 0; i < playerCount; i++)
            {
                PlayerHand hand = new PlayerHand();
                for (int j = 0; j < 13; j++)
                {
                    hand.Hand.Add(GameSet.DrawTile());
                }
                Players.Add(hand);
            }

            doraIndicators.DoraIndicator.Add(GameSet.DrawTile());
        }

        public void DrawTile(int player)
        {
            Tile drawntile = GameSet.DrawTile();
            Players[player].drawn = drawntile;
            Players[player].Hand.Add(drawntile);
        }

        public List<int> DiscardTile(int player, Tile tile)
        {
            int index = 0;
            foreach(Tile item in Players[player].Hand)
            {
                if(tile == item)
                {
                    Players[player].Hand.RemoveAt(index);
                    Players[player].Discard.Add(tile);
                    break;
                }
                index++;
            }

            Players[player].Hand = Players[player].Hand.OrderBy(x => x.Number).ToList();
            Players[player].WinningTiles = MahjongFunctions.GetWinningTiles(Players[player].Hand);

            List<int> WinningPlayers = new List<int>();
            for(int i = 0; i < Players.Count-1; i++)
            {
                if(i == player)
                {
                    continue;
                }

                if (Players[i].WinningTiles.Contains(tile))
                {
                    WinningPlayers.Add(i);
                }
            }

            return WinningPlayers;
        }
    }
}