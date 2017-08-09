<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PizzaWebsite.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.PizzaWebsite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Image ID="Image1" runat="server" ImageUrl="PapaBob.png" />
                Papa Bob&#39;s Pizza and Software</h1>
            <p>
                <asp:RadioButton ID="BabyButton" runat="server" Checked="True" GroupName="Size" Text="Baby Bob Size (10&quot;) - $10" />
                <br />
                <asp:RadioButton ID="MamaButton" runat="server" GroupName="Size" Text="Mama Bob Size (13&quot;) - $13" />
                <br />
                <asp:RadioButton ID="PapaButton" runat="server" GroupName="Size" Text="Papa Bob Size (16&quot;) - $16" />
            </p>
            <p>
                <asp:RadioButton ID="ThinButton" runat="server" Checked="True" GroupName="Crust" Text="Thin Crust" />
                <br />
                <asp:RadioButton ID="DeepButton" runat="server" GroupName="Crust" Text="Deep Dish (+$2)" />
            </p>
            <p>
                <asp:CheckBox ID="PepperoniButton" runat="server" Text="Pepperoni (+$1.50)" />
                <br />
                <asp:CheckBox ID="OnionButton" runat="server" Text="Onions (+$0.75)" />
                <br>
                <asp:CheckBox ID="GreenPepperButton" runat="server" Text="Green Peppers (+$0.50)" />
                <br />
                <asp:CheckBox ID="RedPepperButton" runat="server" Text="Red Peppers (+$0.75)" />
                <br />
                <asp:CheckBox ID="AnchoviesButton" runat="server" Text="Anchovies (+$2.00)" />
            </p>
            <h3>
                Papa Bob&#39;s <span class="auto-style1">Special Deal</span></h3>
            <p>
                Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies OR Pepperoni, Red Peppers, and Onions to your pizza.</p>
            <p>
                <asp:Button ID="PurchaseButton" runat="server" OnClick="PurchaseButton_Click" Text="Purchase" />
            </p>
            <p>
                <asp:Label ID="TotalLabel" runat="server" Text="Total: "></asp:Label>
            </p>
            <p>
                Sorry, at this time you can only order one pizza online, and pick-up only... we need a better website!</p>
        </div>
    </form>
</body>
</html>
