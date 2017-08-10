<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DaysBetweenDates.aspx.cs" Inherits="ChallengeDaysBetweenDates.DaysBetweenDates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How many days have elapsed?<br />
            <br />
            Choose one date:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Choose a second date:<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="OkButton" runat="server" OnClick="Button1_Click" Text=" Ok " />
            <br />
            <br />
            <asp:Label ID="ElapsedDays" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
