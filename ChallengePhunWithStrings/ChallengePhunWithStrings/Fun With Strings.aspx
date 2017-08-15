<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fun With Strings.aspx.cs" Inherits="ChallengePhunWithStrings.Fun_With_Strings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            My name backwards is:
            <asp:Label ID="BackwardsName" runat="server"></asp:Label>
            <br />
            Luke,Leia,Han,Chewbacca in reverse order is:
            <asp:Label ID="ReverseOrder" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
