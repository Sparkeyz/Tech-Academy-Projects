using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpyAssignment
{
    public partial class EpicSpyAssignmentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void AssignButton_Click(object sender, EventArgs e)
        {
            if (Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays < 14)
            {
                AssignLabel.Text = "Error: must allow at least two weeks between previous " +
                    "assignment " + "and new assignment.";
            }
            else
            {
                int totalPrice = 0;
                totalPrice += 500 * (int)Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate)
                    .TotalDays;
                if (totalPrice >= 10500)
                {
                    totalPrice += 1000;
                }
                AssignLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. " +
                    "Budget Total: ${2:2.22}", SpyNameBox.Text, NewAssignmentBox.Text,
                    totalPrice.ToString());
            }
        }
    }
}