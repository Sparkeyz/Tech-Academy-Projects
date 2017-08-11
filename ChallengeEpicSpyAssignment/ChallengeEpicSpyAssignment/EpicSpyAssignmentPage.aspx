<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EpicSpyAssignmentPage.aspx.cs" Inherits="ChallengeEpicSpyAssignment.EpicSpyAssignmentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-family: Arial, Helvetica, sans-serif">
                <asp:Image ID="Image1" runat="server" Height="250px" ImageUrl="~/epic-spies-logo.jpg" Width="190px" />
                <br />
                <br />
                Spy New Assignment Form</h1>
            <p style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                Spy Code Name:
                <asp:TextBox ID="SpyNameBox" runat="server"></asp:TextBox>
            </p>
            <p style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                New Assignment Name:
                <asp:TextBox ID="NewAssignmentBox" runat="server"></asp:TextBox>
            </p>
            <p style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                End Date of Previous Assignment<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </p>
            <p style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                Start Date of New Assignment<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            </p>
            <p style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                Projected End Date of New Assignment<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
            </p>
            <p style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                <asp:Button ID="AssignButton" runat="server" OnClick="AssignButton_Click" Text="Assign Spy" />
            </p>
            <p style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif">
                <asp:Label ID="AssignLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
