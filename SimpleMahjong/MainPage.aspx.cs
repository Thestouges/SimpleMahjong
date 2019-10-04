using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using System.Text;

namespace SimpleMahjong
{
    public partial class MainPage : System.Web.UI.Page
    {
        MahjongFunctions MahjongFunctions;
        List<Tile> hand;
        protected void Page_Load(object sender, EventArgs e)
        {
            MahjongFunctions = new MahjongFunctions();
            hand = new List<Tile>();
            if (Page.IsPostBack)
            {
                ShowHand();
            }
            else
            {
                ShanNum.Value = "";
                handsize.Value = "0";
                Session.Clear();
            }

        }

        private void ShowHand() {
            if (Session["hand"] != null)
            {
                hand = (List<Tile>)Session["hand"];
            }
            else
            {
                return;
            }

            SortHand();
            //string html = "";
            foreach (Tile item in hand)
            {
                //html += "<input type=Image class=myhand src=" + item.GetImagePath() + ">";
                ImageButton ihand = new ImageButton();
                ihand.ToolTip = item.Number.ToString();
                ihand.ImageUrl = item.GetImagePath();
                ihand.CssClass = "myhand";
                ihand.Click += new ImageClickEventHandler((sender, e) => RemoveFromHand(sender, e, item));
                handID.Controls.Add(ihand);
            }
            //handID.InnerHtml = html;
        }

        private void RemoveFromHand(object sender, EventArgs e, Tile tile)
        {
            //Console.WriteLine(tile.Number);
            hand = (List<Tile>)Session["hand"];

            int index = 0;
            foreach(Tile item in hand)
            {
                if(item == tile)
                {
                    hand.RemoveAt(index);
                    break;
                }
                index++;
            }

            AddPostBack();
        }

        private void SortHand()
        {
            if (hand.Count > 0)
            {
                hand = hand.OrderBy(x => x.Number).ToList();
            }
        }

        private void InsertToHand(int num)
        {
            if (Session["hand"] != null)
            {
                hand = (List<Tile>)Session["hand"];
            }

            int insertCounter = 0;
            foreach (Tile item in hand)
            {
                if (item.Number == num)
                {
                    insertCounter++;
                }

                if (insertCounter >= 4)
                {
                    //ShowHand();
                    return;
                }
            }

            if (hand.Count() != 14)
            {
                Tile tile = new Tile();
                tile.Number = num;
                hand.Add(tile);
                Session["hand"] = hand;
            }

            //ShowHand();
            handsize.Value = hand.Count().ToString();

            if (hand.Count() == 14)
            {
                ShowShantenNumber();
            }

            AddPostBack();
        }

        private void AddPostBack()
        {
            StringBuilder sbScript = new StringBuilder();

            sbScript.Append("<script language='JavaScript' type='text/javascript'>\n");
            sbScript.Append("<!--\n");
            //sbScript.Append(this.GetPostBackEventReference(this, "PBArg") + ";\n");
            sbScript.Append(this.ClientScript.GetPostBackEventReference(this, "PBArg") + ";\n");
            sbScript.Append("// -->\n");
            sbScript.Append("</script>\n");

            //this.RegisterStartupScript("AutoPostBackScript", sbScript.ToString());
            this.ClientScript.RegisterStartupScript(this.GetType(),"AutoPostBackScript", sbScript.ToString());
        }

        private void ShowShantenNumber()
        {
            ShanNum.Value = MahjongFunctions.Shanten(hand).ToString();
        }

        protected void btnBamboo1_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(1);
        }

        protected void btnBamboo2_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(2);
        }

        protected void btnBamboo3_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(3);
        }

        protected void btnBamboo4_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(4);
        }

        protected void btnBamboo5_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(5);
        }

        protected void btnBamboo6_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(6);
        }

        protected void btnBamboo7_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(7);
        }

        protected void btnBamboo8_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(8);
        }

        protected void btnBamboo9_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(9);
        }

        protected void btnPin1_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(11);
        }

        protected void btnPin2_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(12);
        }

        protected void btnPin3_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(13);
        }

        protected void btnPin4_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(14);
        }

        protected void btnPin5_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(15);
        }

        protected void btnPin6_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(16);
        }

        protected void btnPin7_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(17);
        }

        protected void btnPin8_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(18);
        }

        protected void btnPin9_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(19);
        }

        protected void btnMan1_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(21);
        }

        protected void btnMan2_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(22);
        }

        protected void btnMan3_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(23);
        }

        protected void btnMan4_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(24);
        }

        protected void btnMan5_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(25);
        }

        protected void btnMan6_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(26);
        }

        protected void btnMan7_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(27);
        }

        protected void btnMan8_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(28);
        }

        protected void btnMan9_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(29);
        }

        protected void btnEast_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(32);
        }

        protected void btnSouth_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(33);
        }

        protected void btnWest_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(34);
        }

        protected void btnNorth_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(35);
        }

        protected void btnRed_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(36);
        }

        protected void White_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(37);
        }

        protected void Green_Click(object sender, ImageClickEventArgs e)
        {
            InsertToHand(38);
        }

        protected void btnClearHand_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect(Request.RawUrl);
        }
    }
}