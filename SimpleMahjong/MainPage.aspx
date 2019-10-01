<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="SimpleMahjong.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" type="text/css" href="~/CSS/Mahjong.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="ShanNum" runat="server" />
        <asp:HiddenField ID="handsize" runat="server" />
        <div>
            <asp:ImageButton ID="btnBamboo1" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo1.png" Class="tile" OnClick="btnBamboo1_Click"/>
            <asp:ImageButton ID="btnBamboo2" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo2.png" Class="tile" OnClick="btnBamboo2_Click"/>
            <asp:ImageButton ID="btnBamboo3" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo3.png" Class="tile" OnClick="btnBamboo3_Click"/>
            <asp:ImageButton ID="btnBamboo4" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo4.png" Class="tile" OnClick="btnBamboo4_Click"/>
            <asp:ImageButton ID="btnBamboo5" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo5.png" Class="tile" OnClick="btnBamboo5_Click"/>
            <asp:ImageButton ID="btnBamboo6" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo6.png" Class="tile" OnClick="btnBamboo6_Click"/>
            <asp:ImageButton ID="btnBamboo7" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo7.png" Class="tile" OnClick="btnBamboo7_Click"/>
            <asp:ImageButton ID="btnBamboo8" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo8.png" Class="tile" OnClick="btnBamboo8_Click"/>
            <asp:ImageButton ID="btnBamboo9" runat="server" ImageUrl="~/TileAssets/bamboo/bamboo9.png" Class="tile" OnClick="btnBamboo9_Click"/>
            <br />
            <asp:ImageButton ID="btnPin1" runat="server" ImageUrl="~/TileAssets/pin/pin1.png" Class="tile" OnClick="btnPin1_Click" />
            <asp:ImageButton ID="btnPin2" runat="server" ImageUrl="~/TileAssets/pin/pin2.png" Class="tile" OnClick="btnPin2_Click"/>
            <asp:ImageButton ID="btnPin3" runat="server" ImageUrl="~/TileAssets/pin/pin3.png" Class="tile" OnClick="btnPin3_Click"/>
            <asp:ImageButton ID="btnPin4" runat="server" ImageUrl="~/TileAssets/pin/pin4.png" Class="tile" OnClick="btnPin4_Click"/>
            <asp:ImageButton ID="btnPin5" runat="server" ImageUrl="~/TileAssets/pin/pin5.png" Class="tile" OnClick="btnPin5_Click"/>
            <asp:ImageButton ID="btnPin6" runat="server" ImageUrl="~/TileAssets/pin/pin6.png" Class="tile" OnClick="btnPin6_Click"/>
            <asp:ImageButton ID="btnPin7" runat="server" ImageUrl="~/TileAssets/pin/pin7.png" Class="tile" OnClick="btnPin7_Click"/>
            <asp:ImageButton ID="btnPin8" runat="server" ImageUrl="~/TileAssets/pin/pin8.png" Class="tile" OnClick="btnPin8_Click"/>
            <asp:ImageButton ID="btnPin9" runat="server" ImageUrl="~/TileAssets/pin/pin9.png" Class="tile" OnClick="btnPin9_Click"/>
            <br />
            <asp:ImageButton ID="btnMan1" runat="server" ImageUrl="~/TileAssets/man/man1.png" Class="tile" OnClick="btnMan1_Click"/>
            <asp:ImageButton ID="btnMan2" runat="server" ImageUrl="~/TileAssets/man/man2.png" Class="tile" OnClick="btnMan2_Click"/>
            <asp:ImageButton ID="btnMan3" runat="server" ImageUrl="~/TileAssets/man/man3.png" Class="tile" OnClick="btnMan3_Click"/>
            <asp:ImageButton ID="btnMan4" runat="server" ImageUrl="~/TileAssets/man/man4.png" Class="tile" OnClick="btnMan4_Click"/>
            <asp:ImageButton ID="btnMan5" runat="server" ImageUrl="~/TileAssets/man/man5.png" Class="tile" OnClick="btnMan5_Click"/>
            <asp:ImageButton ID="btnMan6" runat="server" ImageUrl="~/TileAssets/man/man6.png" Class="tile" OnClick="btnMan6_Click"/>
            <asp:ImageButton ID="btnMan7" runat="server" ImageUrl="~/TileAssets/man/man7.png" Class="tile" OnClick="btnMan7_Click"/>
            <asp:ImageButton ID="btnMan8" runat="server" ImageUrl="~/TileAssets/man/man8.png" Class="tile" OnClick="btnMan8_Click"/>
            <asp:ImageButton ID="btnMan9" runat="server" ImageUrl="~/TileAssets/man/man9.png" Class="tile" OnClick="btnMan9_Click"/>
            <br />
            <asp:ImageButton ID="btnEast" runat="server" ImageUrl="~/TileAssets/winds/wind-east.png" Class="tile" OnClick="btnEast_Click"/>
            <asp:ImageButton ID="btnSouth" runat="server" ImageUrl="~/TileAssets/winds/wind-south.png" Class="tile" OnClick="btnSouth_Click"/>
            <asp:ImageButton ID="btnWest" runat="server" ImageUrl="~/TileAssets/winds/wind-west.png" Class="tile" OnClick="btnWest_Click"/>
            <asp:ImageButton ID="btnNorth" runat="server" ImageUrl="~/TileAssets/winds/wind-north.png" Class="tile" OnClick="btnNorth_Click"/>
            <asp:ImageButton ID="btnRed" runat="server" ImageUrl="~/TileAssets/dragons/dragon-chun.png" Class="tile" OnClick="btnRed_Click"/>
            <asp:ImageButton ID="White" runat="server" ImageUrl="~/TileAssets/dragons/dragon-haku.png" Class="tile" OnClick="White_Click"/>
            <asp:ImageButton ID="Green" runat="server" ImageUrl="~/TileAssets/dragons/dragon-green.png" Class="tile" OnClick="Green_Click"/>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnClearHand" runat="server" Text="Clear Hand" OnClick="btnClearHand_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Hand Size: "></asp:Label> <%=handsize.Value %>
            <asp:Label ID="Label2" runat="server" Text="Shanten Number: "></asp:Label> <%=ShanNum.Value %>
            <div id="handID" runat="server">
                
            </div>
        </div>
    </form>
</body>
</html>
