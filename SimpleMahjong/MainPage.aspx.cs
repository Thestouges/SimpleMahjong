using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleMahjong
{
    public partial class MainPage : System.Web.UI.Page
    {
        MahjongFunctions MahjongFunctions;
        List<Tile> hand;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MahjongFunctions = new MahjongFunctions();
                hand = new List<Tile>();
            }
            else
            {
                ShowHand();
            }
           
        }

        private void ShowHand() {
            SortHand();
            foreach (Tile item in hand)
            {
                handID.InnerHtml += "<asp:ImageButton Class=\"tile\" ImageUrl=\"" + item.GetImagePath();
            }
        }

        private void SortHand()
        {
            hand.OrderBy(x => x.Number);
        }
        
        protected void btnBamboo1_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 1;
            hand.Add(tile);
        }

        protected void btnBamboo2_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 2;
            hand.Add(tile);
        }

        protected void btnBamboo3_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 3;
            hand.Add(tile);
        }

        protected void btnBamboo4_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 4;
            hand.Add(tile);
        }

        protected void btnBamboo5_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 5;
            hand.Add(tile);
        }

        protected void btnBamboo6_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 6;
            hand.Add(tile);
        }

        protected void btnBamboo7_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 7;
            hand.Add(tile);
        }

        protected void btnBamboo8_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 8;
            hand.Add(tile);
        }

        protected void btnBamboo9_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 9;
            hand.Add(tile);
        }

        protected void btnPin1_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 11;
            hand.Add(tile);
        }

        protected void btnPin2_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 12;
            hand.Add(tile);
        }

        protected void btnPin3_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 13;
            hand.Add(tile);
        }

        protected void btnPin4_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 14;
            hand.Add(tile);
        }

        protected void btnPin5_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 15;
            hand.Add(tile);
        }

        protected void btnPin6_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 16;
            hand.Add(tile);
        }

        protected void btnPin7_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 17;
            hand.Add(tile);
        }

        protected void btnPin8_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 18;
            hand.Add(tile);
        }

        protected void btnPin9_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 19;
            hand.Add(tile);
        }

        protected void btnMan1_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 21;
            hand.Add(tile);
        }

        protected void btnMan2_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 22;
            hand.Add(tile);
        }

        protected void btnMan3_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 23;
            hand.Add(tile);
        }

        protected void btnMan4_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 24;
            hand.Add(tile);
        }

        protected void btnMan5_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 25;
            hand.Add(tile);
        }

        protected void btnMan6_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 26;
            hand.Add(tile);
        }

        protected void btnMan7_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 27;
            hand.Add(tile);
        }

        protected void btnMan8_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 28;
            hand.Add(tile);
        }

        protected void btnMan9_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 29;
            hand.Add(tile);
        }

        protected void btnEast_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 32;
            hand.Add(tile);
        }

        protected void btnSouth_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 33;
            hand.Add(tile);
        }

        protected void btnWest_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 34;
            hand.Add(tile);
        }

        protected void btnNorth_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 35;
            hand.Add(tile);
        }

        protected void btnRed_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 36;
            hand.Add(tile);
        }

        protected void White_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 37;
            hand.Add(tile);
        }

        protected void Green_Click(object sender, ImageClickEventArgs e)
        {
            Tile tile = new Tile();
            tile.Number = 38;
            hand.Add(tile);
        }
    }
}