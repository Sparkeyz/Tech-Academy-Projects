<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Casino.aspx.cs" Inherits="MegaChallengeCasino.Casino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
&nbsp;<asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
&nbsp;<asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
            <br />
            <br />
            Your Bet:
            <asp:TextBox ID="BetBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Lever" runat="server" OnClick="Lever_Click" Text="Pull The Lever!" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry - x2 Your Bet<br />
            2 Cherries - x3 Your Bet<br />
            3 Cherries - x4 Your Bet<br />
            3 7&#39;s - Jackpot - 100x Your Bet<br />
            HOWEVER... If there&#39;s even one bar you win nothing.
        </div>
    </form>
</body>
</html>
