using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class PostalCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            calculate();
        }

        protected void GroundButton_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        protected void AirButton_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        protected void NextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        protected void WidthBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        protected void HeightBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        protected void LengthBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            if (WidthBox.Text.Trim().Length!=0 && HeightBox.Text.Trim().Length!=0)
            {
                int width = int.Parse(WidthBox.Text);
                int height = int.Parse(HeightBox.Text);
                if (AirButton.Checked)
                {
                    findPrice(0.25, width, height);
                } else if (GroundButton.Checked)
                {
                    findPrice(0.15, width, height);
                } else if (NextDayButton.Checked)
                {
                    findPrice(0.45, width, height);
                } else
                {
                    return;
                }
            } else
            {
                return;
            }
        }

        private void findPrice(double multiplier, int width, int height)
        {
            int length = 1;
            if (LengthBox.Text.Trim().Length!=0)
            {
                length = int.Parse(LengthBox.Text.Trim().ToString());
            }
            double price = multiplier * width * length * height;
            resultLabel.Text = string.Format("Your parcel will cost ${0:C}", price.ToString());
        }
    }
}