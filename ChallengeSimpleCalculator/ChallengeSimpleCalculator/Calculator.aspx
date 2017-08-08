<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="ChallengeSimpleCalculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                First Value:&nbsp;
                <asp:TextBox ID="ValueBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                Second Value:&nbsp;
                <asp:TextBox ID="ValueBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Plus" runat="server" OnClick="Button1_Click" Text=" + " />
&nbsp;<asp:Button ID="Minus" runat="server" Text=" - " OnClick="Minus_Click" />
&nbsp;<asp:Button ID="Multiply" runat="server" Text=" * " OnClick="Multiply_Click" />
&nbsp;<asp:Button ID="Divide" runat="server" Text=" / " OnClick="Divide_Click" />
&nbsp;</p>
            <p>
                <asp:Label ID="Result" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
