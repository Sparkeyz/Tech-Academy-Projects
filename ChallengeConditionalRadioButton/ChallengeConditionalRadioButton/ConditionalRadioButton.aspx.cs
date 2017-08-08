using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class ConditionalRadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            if (PencilButton.Checked)
            {
                Label1.Text = "You selected Pencil";
                Image1.ImageUrl = "pencil.png";
            } else if (PenButton.Checked)
            {
                Label1.Text = "You selected Pen";
                Image1.ImageUrl = "pen.png";
            } else if (PhoneButton.Checked)
            {
                Label1.Text = "You selected Phone";
                Image1.ImageUrl = "phone.png";
            } else if (TabletButton.Checked)
            {
                Label1.Text = "You selected Tablet";
                Image1.ImageUrl = "tablet.png";
            } else
            {
                Label1.Text = "Please select an option";
            }
        }
    }
}