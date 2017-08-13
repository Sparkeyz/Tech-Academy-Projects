<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostalCalculator.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.PostalCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:
            <asp:TextBox ID="WidthBox" runat="server" AutoPostBack="True" OnTextChanged="WidthBox_TextChanged"></asp:TextBox>
            <br />
            Height: <asp:TextBox ID="HeightBox" runat="server" AutoPostBack="True" OnTextChanged="HeightBox_TextChanged"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="LengthBox" runat="server" AutoPostBack="True" OnTextChanged="LengthBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="GroundButton" runat="server" GroupName="Shipping" Text="Ground" AutoPostBack="True" OnCheckedChanged="GroundButton_CheckedChanged" />
            <br />
            <asp:RadioButton ID="AirButton" runat="server" GroupName="Shipping" Text="Air" AutoPostBack="True" OnCheckedChanged="AirButton_CheckedChanged" />
            <br />
            <asp:RadioButton ID="NextDayButton" runat="server" GroupName="Shipping" Text="Next Day" AutoPostBack="True" OnCheckedChanged="NextDayButton_CheckedChanged" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
