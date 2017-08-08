using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(ValueBox1.Text);
            double val2 = double.Parse(ValueBox2.Text);

            double result = val1 + val2;
            Result.Text = result.ToString();
            /*Note that these four methods are repetitive and could be
              easily optimized, but the tutorial didn't get that far yet
              so I left it as is*/
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(ValueBox1.Text);
            double val2 = double.Parse(ValueBox2.Text);

            double result = val1 - val2;
            Result.Text = result.ToString();
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(ValueBox1.Text);
            double val2 = double.Parse(ValueBox2.Text);

            double result = val1 * val2;
            Result.Text = result.ToString();
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(ValueBox1.Text);
            double val2 = double.Parse(ValueBox2.Text);

            double result = val1 / val2;
            Result.Text = result.ToString();
        }
    }
}