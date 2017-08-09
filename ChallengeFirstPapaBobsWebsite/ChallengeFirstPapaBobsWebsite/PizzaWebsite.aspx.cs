using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class PizzaWebsite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PurchaseButton_Click(object sender, EventArgs e)
        {
            double price = 0.00;
            if (BabyButton.Checked)
            {
                price += 10.00;
            } else if (MamaButton.Checked)
            {
                price += 13.00;
            } else
            {
                price += 16.00;
            }
            if (DeepButton.Checked)
            {
                price += 2.00;
            }
            if (PepperoniButton.Checked)
            {
                price += 1.50;
            }
            if (OnionButton.Checked)
            {
                price += 0.75;
            }
            if (GreenPepperButton.Checked)
            {
                price += 0.50;
            }
            if (RedPepperButton.Checked)
            {
                price += 0.75;
            }
            if (AnchoviesButton.Checked)
            {
                price += 2.00;
            }
            if ((PepperoniButton.Checked && GreenPepperButton.Checked && AnchoviesButton.Checked) 
                || (PepperoniButton.Checked && RedPepperButton.Checked && OnionButton.Checked))
            {
                price -= 2.00;
            }
            TotalLabel.Text = "Total: $" + price;
        }
    }
}