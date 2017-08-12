<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssetTracker.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.AssetTracker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
                <asp:Image ID="Image1" runat="server" Height="242px" ImageUrl="~/epic-spies-logo.jpg" Width="190px" />
                <br />
                <br />
                Asset Performance Tracker</h2>
            <p>
                Asset Name:
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            </p>
            <p>
                Elections Rigged:
                <asp:TextBox ID="Rigs" runat="server"></asp:TextBox>
            </p>
            <p>
                Acts of Subterfuge Performed:
                <asp:TextBox ID="Subterfuges" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add Asset" />
            </p>
            <p>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
