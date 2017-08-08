<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConditionalRadioButton.aspx.cs" Inherits="ChallengeConditionalRadioButton.ConditionalRadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking preferences<br />
            <br />
            <asp:RadioButton ID="PencilButton" runat="server" GroupName="NoteTaking" Text="Pencil" />
            <br />
            <asp:RadioButton ID="PenButton" runat="server" GroupName="NoteTaking" Text="Pen" />
            <br />
            <asp:RadioButton ID="PhoneButton" runat="server" GroupName="NoteTaking" Text="Phone" />
            <br />
            <asp:RadioButton ID="TabletButton" runat="server" GroupName="NoteTaking" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text=" Ok " />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
